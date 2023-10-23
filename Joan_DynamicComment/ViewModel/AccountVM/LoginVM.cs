using System;
using System.ComponentModel.DataAnnotations;

namespace Joan_DynamicComment.ViewModel.AccountVM
{
	public class LoginVM
	{
		public string UserNameOrEmail { get; set; }
		[DataType(DataType.Password)]
		public string Password { get; set; }
		public bool Remember { get; set; }
		public LoginVM()
		{
		}
	}
}

