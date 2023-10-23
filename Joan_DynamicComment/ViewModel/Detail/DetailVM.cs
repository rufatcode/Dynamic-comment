using System;
using Joan_DynamicComment.Models;

namespace Joan_DynamicComment.ViewModel.Detail
{
	public class DetailVM
	{
		public string UserName { get; set; }
		public string Email { get; set; }
		public Product Product { get; set; }
		public List<Product> SearchProducts { get; set; }
		public DetailVM()
		{
			SearchProducts = new();
		}
	}
}

