﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace JamesThewWebMVC.Models
{
	public class LoginModel
	{
		[Required(ErrorMessage = "Yêu cầu nhập tên đăng nhập")]
		[Display(Name = "Tên đăng nhập")]
		public string UserName { get; set; }
		[Required(ErrorMessage = "Yêu cầu nhập mật khẩu")]
		[Display(Name = "Mật khẩu")]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
