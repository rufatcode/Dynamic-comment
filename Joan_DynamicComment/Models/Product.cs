using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joan_DynamicComment.Models
{
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int Price { get; set; }
		public int SalePercantage { get; set; }
		public string Description { get; set; }
		[ForeignKey(nameof(Category))]
		public int CategoryId { get; set; }
		public Category Category { get; set; }
		public List<ProductImage> ProductImages { get; set; }
		public List<Comment> Comments { get; set; }
		public bool IsDeleted { get; set; }
		public bool IsAvaliable { get; set; }
		public int Count { get; set; }
		public DateTime CreatedAt { get; set; }
		public Product()
		{
			ProductImages = new();
			Comments = new();
		}
	}
}

