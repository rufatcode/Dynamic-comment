using System;
using System.ComponentModel.DataAnnotations;

namespace Joan_DynamicComment.ViewModel.AccountVM
{
	public class ResetPasswordVM
	{
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[DataType(DataType.Password),Compare("Password")]
		public string RepeatPassword { get; set; }
		public ResetPasswordVM()
		{
		}
	}
}

