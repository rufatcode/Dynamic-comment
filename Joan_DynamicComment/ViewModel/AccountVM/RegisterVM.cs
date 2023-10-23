﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Joan_DynamicComment.ViewModel.AccountVM
{
	public class RegisterVM
	{
		public IFormFile ProfileImgUrl { get; set; }
		public string UserName { get; set; }
		public string FullName { get; set; }
		[EmailAddress,DataType(DataType.EmailAddress)]
		public string Email { get; set; }
		[DataType(DataType.Password)]
		public string Password { get; set; }
		[DataType(DataType.Password),Compare("Password")]
		public string Repeatpassword { get; set; }

		public RegisterVM()
		{
		}
	}
}

