using System;
using System.ComponentModel.DataAnnotations;

namespace TeachersManagementApp.Models.Domain
{
	public class Role
	{
		public int Id { get; set; }

		[Required]
		public string RoleName { get; set; }
	}
}

