using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Joan_DynamicComment.Models
{
	public class AppUser:IdentityUser
	{
		public string FullName { get; set; }
		public List<Comment> Comments { get; set; }
		public bool IsActive { get; set; }
		public string? ProfileImgUrl { get; set; }
        public AppUser()
		{
			Comments = new();
		}
	}
}

