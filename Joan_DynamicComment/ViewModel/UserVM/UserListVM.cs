using System;
using Joan_DynamicComment.Models;
using Microsoft.AspNetCore.Identity;

namespace Joan_DynamicComment.ViewModel.UserVM
{
	public class UserListVM
	{
		public string Id { get; set; }
		public string UserName { get; set; }
		public IList<string> Roles { get; set; }
		public UserListVM()
		{
		}
		
	}
}

