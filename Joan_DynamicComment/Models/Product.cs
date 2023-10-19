using System;
namespace Joan_DynamicComment.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public int SalePercantage { get; set; }
		public string Description { get; set; }
		public List<ProductImage> ProductImages { get; set; }
		public Product()
		{
			ProductImages = new();
		}
	}
}

