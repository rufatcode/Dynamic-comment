using System;
namespace Joan_DynamicComment.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Content { get; set; }
		public List<Product> Products { get; set; }
		public Category()
		{
		}
	}
}

