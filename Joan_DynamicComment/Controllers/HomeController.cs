using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Joan_DynamicComment.DAL;
using Joan_DynamicComment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Joan_DynamicComment.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/
        private AppDbContext _context { get; }
        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Products.Include(p=>p.Category).Include(p=>p.ProductImages).AsNoTracking().ToList());
        }
        public async Task<IActionResult> Detail(int? id)
        {
            if (id==null)
            {
                return BadRequest();
            }
            Product product = await _context.Products.Include(p=>p.ProductImages).Include(p=>p.Category).AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
            if (product==null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> Comment(string commnet,int productId)
        {
            if (!User.Identity.IsAuthenticated)
            {
                TempData["Warning"] = "Please register for comment writing";
                return Redirect($"/Home/Detail/{productId}");
            }
            return Redirect($"/Home/Detail/{productId}");
        }
    }
}

