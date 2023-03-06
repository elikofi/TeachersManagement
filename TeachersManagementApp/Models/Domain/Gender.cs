using System;
using System.ComponentModel.DataAnnotations;

namespace TeachersManagementApp.Models.Domain
{
	public class Gender
	{
		public int Id { get; set; }

		[Required]
		public string GenderName { get; set; }
	}
}

