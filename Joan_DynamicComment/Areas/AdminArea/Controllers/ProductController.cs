using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Joan_DynamicComment.DAL;
using Joan_DynamicComment.Models;
using Joan_DynamicComment.ViewModel.ProductVM;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Joan_DynamicComment.Areas.AdminArea.Controllers
{
    [Area("AdminArea")]
    public class ProductController : Controller
    {
        // GET: /<controller>/
        private AppDbContext _context { get; }
        private IWebHostEnvironment _webHostEnvironment { get; }
        public ProductController(AppDbContext context,IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View(_context.Products.AsNoTracking().Include(p=>p.ProductImages).ToList());
        }
        public IActionResult Create()
        {
            ViewBag.Catagories = new SelectList(_context.Categories.ToList(), "Id", "Name");
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(CreateProductVM createProductVM)
        {
            ViewBag.Catagories = new SelectList(_context.Categories.ToList(), "Id", "Name");
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (_context.Products.Any(p=>p.Name.ToLower()==createProductVM.Name.ToLower()))
            {
                ModelState.AddModelError("Name", "Product Name must be unique for every products");
                return View();
            }
            Product product = new();
            int demo = 0;
            foreach (var image in createProductVM.formFiles)
            {
                if (image.Length/1024>1000)
                {
                    ModelState.AddModelError("formFiles", "Image Length must be smaller than 1 kb");
                    return View();
                }
                else if (!image.ContentType.Contains("image"))
                {
                    ModelState.AddModelError("formFiles", "please upload only image");
                    return View();
                }
              
            }
            foreach (var image in createProductVM.formFiles)
            {
                string imageName = Guid.NewGuid().ToString() + ".jpeg";
                string path = Path.Combine(_webHostEnvironment.WebRootPath, "assets", "img", imageName);
                using (FileStream fileStream = new FileStream(path, FileMode.Create))
                {
                    image.CopyTo(fileStream);
                }
                if (demo == 0)
                {
                    product.ProductImages.Add(new ProductImage { ProductId = product.Id, ImgUrl = imageName, IsMain = true });
                }
                else
                {
                    product.ProductImages.Add(new ProductImage { ProductId = product.Id, ImgUrl = imageName, IsMain = false });
                }
                demo++;
            }
            product.CategoryId = createProductVM.CategoryId;
            product.Description = createProductVM.Description;
            product.Name = createProductVM.Name;
            product.Price = createProductVM.Price;
            product.SalePercantage = createProductVM.SalePercantage;
            await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int?id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            Product product =await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product==null)
            {
                return NotFound();
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            Product product =await _context.Products.Include(p=>p.Category).Include(p=>p.ProductImages).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
            if (product==null)
            {
                return NotFound();
            }
            return View(product);
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            Product product =await _context.Products.Include(p=>p.ProductImages).Include(p=>p.Category).FirstOrDefaultAsync(p => p.Id == id);

            if (product==null)
            {
                return NotFound();
            }
            ViewBag.Catagories = new SelectList(_context.Categories.ToList(), "Id", "Name");
            UpdateProductVM updateProductVM = new();
            foreach (var image in product.ProductImages)
            {
                updateProductVM.Images.Add(image.ImgUrl);
            }
            updateProductVM.Name = product.Name;
            updateProductVM.Price = product.Price;
            updateProductVM.SalePercantage = product.SalePercantage;
            updateProductVM.Description = product.Description;
            updateProductVM.CategoryId = product.CategoryId;
            return View(updateProductVM);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Update(int ?id,UpdateProductVM updateProductVM)
        {
            ViewBag.Catagories = new SelectList(_context.Categories.ToList(), "Id", "Name");
            if (!ModelState.IsValid)
            {
                return View();
            }

            Product product =await _context.Products.Include(p=>p.ProductImages).FirstOrDefaultAsync(p => p.Id == id);
            foreach (var image in product.ProductImages)
            {
                updateProductVM.Images.Add(image.ImgUrl);
            }
            if (_context.Products.Any(p=>p.Name.ToLower()==updateProductVM.Name.ToLower()&&updateProductVM.Name.ToLower()!=product.Name.ToLower()))
            {
                ModelState.AddModelError("Name", "Every Product Name must be undiqe");
                return View(updateProductVM);
            }
            if (updateProductVM.formFiles!=null)
            {
                foreach (var image in product.ProductImages)
                {
                    System.IO.File.Delete(Path.Combine(_webHostEnvironment.WebRootPath, "assets", "img", image.ImgUrl));
                    _context.ProductImages.Remove (image);
                }
                foreach (var image in updateProductVM.formFiles)
                {
                    if (image.Length / 1024 > 1000)
                    {
                        ModelState.AddModelError("formFiles", "Image Length must be smaller than 1 kb");
                        return View();
                    }
                    else if (!image.ContentType.Contains("image"))
                    {
                        ModelState.AddModelError("formFiles", "please upload only image");
                        return View();
                    }

                }
                int demo = 0;
                foreach (var image in updateProductVM.formFiles)
                {
                    string imageName = Guid.NewGuid().ToString() + ".jpeg";
                    string path = Path.Combine(_webHostEnvironment.WebRootPath, "assets", "img", imageName);
                    using (FileStream fileStream = new FileStream(path, FileMode.Create))
                    {
                        image.CopyTo(fileStream);
                    }
                    if (demo == 0)
                    {
                        product.ProductImages.Add(new ProductImage { ProductId = product.Id, ImgUrl = imageName, IsMain = true });
                    }
                    else
                    {
                        product.ProductImages.Add(new ProductImage { ProductId = product.Id, ImgUrl = imageName, IsMain = false });
                    }
                    demo++;
                }

            }
            product.Name = updateProductVM.Name;
            product.Price = updateProductVM.Price;
            product.Description = updateProductVM.Description;
            product.CategoryId = updateProductVM.CategoryId;
            await _context.SaveChangesAsync();

            
            return RedirectToAction("Index");
        } 
    }
}

