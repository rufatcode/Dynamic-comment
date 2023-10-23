using System;
using Joan_DynamicComment.Models;

namespace Joan_DynamicComment.ViewModel.RoleVM
{
	public class DetailRoleVM
	{
		public string Role { get; set; }
		public IList<AppUser> Users { get; set; }
		public DetailRoleVM()
		{
		}
	}
}

