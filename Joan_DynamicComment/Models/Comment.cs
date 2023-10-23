using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Joan_DynamicComment.Models
{
	public class Comment
	{
		public int Id { get; set; }
		[ForeignKey(nameof(AppUser))]
		public string AppUserId { get; set; }
		public AppUser AppUser { get; set; }
		public string Content { get; set; }
		public DateTime Date { get; set; } 
		public Product Product { get; set; }
		[ForeignKey(nameof(Product))]
		public int ProductId { get; set; }
		public bool IsDeleted { get; set; }
		public Comment()
		{
		}
	}
}

