using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Joan_DynamicComment.Models;
using Joan_DynamicComment.ViewModel.AccountVM;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Joan_DynamicComment.Controllers
{
    public class AccountController : Controller
    {
        // GET: /<controller>/
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public AccountController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager,IWebHostEnvironment webHostEnvironment)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (_userManager.Users.Any(u=>u.UserName.ToLower()==registerVM.UserName.ToLower()))
            {
                ModelState.AddModelError("UserName", "Username must be unique for every user");
                return View();
            }
            AppUser appUser = new();
            appUser.UserName = registerVM.UserName;
            appUser.FullName = registerVM.FullName;
            appUser.Email = registerVM.Email;
            appUser.IsActive = true;
            if (!registerVM.ProfileImgUrl.ContentType.Contains("image"))
            {
                ModelState.AddModelError("ProfileImgUrl", "must upload only image");
                return View();
            }
            else if (registerVM.ProfileImgUrl.Length/1024>1000)
            {
                ModelState.AddModelError("ProfileImgUrl", "image size must be smaller than 1kb");
                return View();
            }
            string fileName = Guid.NewGuid().ToString()+".jpeg";
            string path = Path.Combine(_webHostEnvironment.WebRootPath, "assets", "img", fileName);
            
            appUser.ProfileImgUrl = fileName;
            
            var resoult=await _userManager.CreateAsync(appUser, registerVM.Password);
            if (resoult.Succeeded)
            {
                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    await registerVM.ProfileImgUrl.CopyToAsync(fileStream);
                }
            }
            else if (!resoult.Succeeded)
            {
                foreach (var error in resoult.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
                return View();
            }
            await _userManager.AddToRoleAsync(appUser, "User");
            string token =await _userManager.GenerateEmailConfirmationTokenAsync(appUser);
            var link = Url.Action(nameof(VerifyEmail), "Account", new {VerifyEmail=appUser.Email,token},Request.Scheme,Request.Host.ToString());
            MailMessage mailMessage = new();
            mailMessage.From=new MailAddress("rufatri@code.edu.az", "Joan App");
            mailMessage.To.Add(new MailAddress(appUser.Email));
            mailMessage.Subject = "verify Email";
            var verifyEmailHtmlContent = string.Empty;
            using (StreamReader streamReader = new StreamReader("wwwroot/Verification/VerificationEmail.html"))
            {
                verifyEmailHtmlContent =await streamReader.ReadToEndAsync();
            }
            verifyEmailHtmlContent= verifyEmailHtmlContent.Replace("{{link}}", link);
            verifyEmailHtmlContent = verifyEmailHtmlContent.Replace("{{userName}}", appUser.UserName);
            mailMessage.Body = verifyEmailHtmlContent;
            mailMessage.IsBodyHtml = true;
            SmtpClient smtpClient = new();
            smtpClient.Port = 587;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.EnableSsl = true;
            smtpClient.Credentials = new NetworkCredential("rufatri@code.edu.az", "bazi tvxk bnta hymo");
            smtpClient.Send(mailMessage);
            TempData["Verification"] = "Please Verify Account";
            return RedirectToAction("Login","Account");
        }
        public async Task<IActionResult> VerifyEmail(string VerifyEmail, string token)
        {
            AppUser appUser =await _userManager.FindByEmailAsync(VerifyEmail);
            if (appUser==null)
            {
                return RedirectToAction("TokenIsNotValid");
            }
            bool isSuccess = await _userManager.VerifyUserTokenAsync(appUser, _userManager.Options.Tokens.EmailConfirmationTokenProvider, "VerifyEmail", token);
            if (!isSuccess)
            {
                return RedirectToAction("TokenIsNotValid");
            }
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> VerifyEmail(string VerifyEmail,string token, int id)
        {
            AppUser appUser =await _userManager.FindByEmailAsync(VerifyEmail);
            await _userManager.ConfirmEmailAsync(appUser, token);
            await _userManager.UpdateSecurityStampAsync(appUser);
            return RedirectToAction("Login");
        }
        public IActionResult TokenIsNotValid()
        {
            return View();
        }
        public async Task<IActionResult> Login()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Login(LoginVM loginVM, string? ReturnUrl)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser appUser = await _userManager.FindByEmailAsync(loginVM.UserNameOrEmail);
            if (appUser==null)
            {
                appUser = await _userManager.FindByNameAsync(loginVM.UserNameOrEmail);
                if (appUser==null)
                {
                    ModelState.AddModelError("UserNameOrEmail", "User is not valid");
                    return View();
                }
            }
            if (!appUser.IsActive)
            {
                ModelState.AddModelError("", "User is not active");
                return View();
            }
            var resoult = await _signInManager.PasswordSignInAsync(appUser, loginVM.Password, loginVM.Remember, true);
            if (resoult.IsLockedOut)
            {
                ModelState.AddModelError("", "User is blocked");
                return View();
            }
            else if (!appUser.EmailConfirmed)
            {
                ModelState.AddModelError("", "Pleae verify account");
                return View();
            }
            else if (!resoult.Succeeded)
            {
                ModelState.AddModelError("", "Something went wrong");
                return View();
            }
            await _signInManager.SignInAsync(appUser, loginVM.Remember);
            if (ReturnUrl!=null)
            {
                return Redirect(ReturnUrl);
            }
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> ForgerPassword()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ForgetPassword(string email)
        {
            AppUser appUser =await _userManager.FindByEmailAsync(email);
            if (appUser==null)
            {
                ModelState.AddModelError("Email", "User is not valid");
                return View();
            }
            else if (!appUser.IsActive)
            {
                ModelState.AddModelError("", "User is not active");
                return View();
            }
            else if (await _userManager.IsLockedOutAsync(appUser))
            {
                ModelState.AddModelError("", "User is blocked");
                return View();
            }
            var token =await _userManager.GeneratePasswordResetTokenAsync(appUser);
            var link = Url.Action(nameof(ResetPassword), "Account", new { email = appUser.Email, token }, Request.Scheme, Request.Host.ToString());
            MailMessage mailMessage = new();
            mailMessage.From = new MailAddress("rufatri@code.edu.az", "Joan App");
            mailMessage.To.Add(new MailAddress(appUser.Email));
            mailMessage.Subject = "Reset Password";
            mailMessage.Body = $"<a href={link}>Reset Password</a>";
            mailMessage.IsBodyHtml = true;
            SmtpClient smtpClient = new();
            smtpClient.Port = 587;
            smtpClient.EnableSsl = true;
            smtpClient.Host = "smtp.gmail.com";
            smtpClient.Credentials = new NetworkCredential("rufatri@code.edu.az", "bazi tvxk bnta hymo");
            smtpClient.Send(mailMessage);
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> ResetPassword(string email, string token)
        {
            AppUser appUser = await _userManager.FindByEmailAsync(email);
            if (appUser==null||await _userManager.IsLockedOutAsync(appUser))
            {
                return RedirectToAction("TokenIsNotValid");
            }
            bool isSuccess =await _userManager.VerifyUserTokenAsync(appUser, _userManager.Options.Tokens.PasswordResetTokenProvider, "ResetPassword", token);
            if (!isSuccess)
            {
                return RedirectToAction("TokenIsNotValid");
            }
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> ResetPassword(string email,string token,ResetPasswordVM resetPasswordVM)
        {
            AppUser appUser = await _userManager.FindByEmailAsync(email);
            await _userManager.ResetPasswordAsync(appUser, token, resetPasswordVM.Password);
            await _userManager.UpdateSecurityStampAsync(appUser);
            return RedirectToAction("Login");
        }
        
        public async Task<IActionResult> LogOut()
        {
           await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
       
    }
}

