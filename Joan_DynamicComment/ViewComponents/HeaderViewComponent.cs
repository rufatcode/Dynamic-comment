using System;
using Joan_DynamicComment.DAL;
using Joan_DynamicComment.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Joan_DynamicComment.ViewComponents
{
	public class HeaderViewComponent:ViewComponent
	{
		private readonly AppDbContext _context;
		private readonly UserManager<AppUser> _userManager;
        public HeaderViewComponent(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
			_userManager = userManager;
        }

       
		public async Task<IViewComponentResult> InvokeAsync()
		{
			

            if (User.Identity.IsAuthenticated)
			{
                ViewBag.User = await _userManager.FindByNameAsync(User.Identity.Name);
            }
			return View(await _context.NavBars.FirstOrDefaultAsync());
		}
	}
}

