﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Joan_DynamicComment.DAL;
using Joan_DynamicComment.Models;
using Joan_DynamicComment.ViewModel.Detail;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Joan_DynamicComment.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        private AppDbContext _context { get; }
        private readonly UserManager<AppUser> _userManager;
        public HomeController(AppDbContext context,UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public IActionResult Index()
        {
            return View(_context.Products.Include(p=>p.Category).Include(p=>p.ProductImages).AsNoTracking().Where(p=>!p.IsDeleted).ToList());
        }
        public async Task<IActionResult> Detail(int? id)
        {
            DetailVM detail = new();
            if (id==null)
            {
                return BadRequest();
            }
            AppUser appUser = new();
            if (User.Identity.IsAuthenticated)
            {
                 appUser= await _userManager.FindByNameAsync(User.Identity.Name);
            }
           detail.UserName = User.Identity.IsAuthenticated? appUser.UserName:"";
           detail.Email = User.Identity.IsAuthenticated? appUser.Email:"";
            Product product = await _context.Products.Include(p=>p.Comments).ThenInclude(c=>c.AppUser).Include(p=>p.ProductImages).Include(p=>p.Category).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
            if (product==null||product.IsDeleted)
            {
                return RedirectToAction("TokenIsNotValid","Account");
            }
            detail.SearchProducts = _context.Products
                .Include(p => p.ProductImages)
                .Take(5)
                .AsNoTracking()
                .Where(p=>p.Id!=product.Id)
                .ToList();
            detail.Product = product;
            return View(detail);
        }
        [HttpPost]
        public async Task<IActionResult> Comment(string commnet,int productId)
        {
            if (commnet.Trim()=="")
            {
                return RedirectToAction("TokenIsNotValid", "Account");
            }
            if (!User.Identity.IsAuthenticated)
            {
                TempData["Warning"] = "Please register for comment writing";
                return Redirect($"/Home/Detail/{productId}");
            }
            AppUser appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            Product product =await _context.Products.FirstOrDefaultAsync(p => p.Id == productId);
            _context.Comments.Add(new Comment { IsDeleted = false,AppUserId=appUser.Id,ProductId=productId,Content=commnet,Date=DateTime.Now });
            await _context.SaveChangesAsync();
            return Redirect($"/Home/Detail/{productId}");
        }
        [HttpPost]
        public async Task<IActionResult> Detail(string productName, int productId)
        {
            DetailVM detail = new();
                List<Product> products=_context.Products
                .Include(p => p.ProductImages)
                .AsNoTracking()
                .Where(p => p.Name.ToLower().Contains(productName.ToLower()))
                .ToList();
            if (products.Count==0)
            {
                products= _context.Products
                .Include(p => p.ProductImages)
                .AsNoTracking()
                .Take(5)
                .ToList();
            }
            detail.SearchProducts = products;
            detail.Product = await _context.Products.Include(p=>p.Comments).ThenInclude(c=>c.AppUser).Include(p => p.ProductImages).Include(p => p.Category).AsNoTracking().FirstOrDefaultAsync(p => p.Id == productId);
            AppUser appUser = new();
            if (User.Identity.IsAuthenticated)
            {
                appUser = await _userManager.FindByNameAsync(User.Identity.Name);
            }
            detail.UserName = User.Identity.IsAuthenticated ? appUser.UserName : "";
            detail.Email = User.Identity.IsAuthenticated ? appUser.Email : "";
            return View(detail);
        }
        public async Task<IActionResult> RemoveComment(int? id, int productId)
        {
            if (id==null)
            {
                return RedirectToAction("TokenIsNotValid", "Account");
            }
            else if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("TokenIsNotValid", "Account");
            }
            Comment comment = await _context.Comments.FirstOrDefaultAsync(c => c.Id == id);
            if (comment==null)
            {
                return RedirectToAction("TokenIsNotValid", "Account");
            }
            comment.IsDeleted = true;
            await _context.SaveChangesAsync();
            return Redirect($"/Home/Detail/{productId}");
        }
        public async Task<IActionResult> UpdateComment(int?id,int productId)
        {
            if (id==null)
            {
                return BadRequest();
            }

            return View();
        }
        [HttpPost]
        public async Task<IActionResult> UpdateComment(string content,int productId,int commentId)
        {
            if (content.Trim()=="")
            {
                return BadRequest();
            }
            else if (productId==null||commentId==null)
            {
                return RedirectToAction("TokenIsNotValid", "Account");
            }
            Comment comment = await _context.Comments.FirstOrDefaultAsync(c => c.Id == commentId);
            if (comment == null||comment.IsDeleted)
            {
                return RedirectToAction("TokenIsNotValid", "Account");
            }
            comment.Content = content;
            await _context.SaveChangesAsync();
            return Redirect($"/Home/Detail/{productId}");
        }
    }
}

