using System;
using Joan_DynamicComment.DAL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Joan_DynamicComment.ViewComponents
{
	public class FooterViewComponent:ViewComponent
	{
		private readonly AppDbContext _context;

        public FooterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        
		public async Task<IViewComponentResult> InvokeAsync()
		{

			return View(await _context.NavBars.ToDictionaryAsync(n => n.Key,n=>n.Value)) ;
		}
	}
}

