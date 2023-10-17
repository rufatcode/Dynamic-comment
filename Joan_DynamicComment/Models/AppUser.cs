using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace Joan_DynamicComment.Models
{
	public class AppUser:IdentityUser
	{
		public string FullName { get; set; }
		public AppUser()
		{
		}
	}
}

