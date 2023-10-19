using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joan_DynamicComment.Models
{
	public class ProductImage
	{
		public int Id { get; set; }
		[ForeignKey(nameof(Product))]
		public int ProductId { get; set; }
		public Product Product { get; set; }
		public string ImgUrl { get; set; }
		public bool IsMain { get; set; }
		public ProductImage()
		{
		}
	}
}

