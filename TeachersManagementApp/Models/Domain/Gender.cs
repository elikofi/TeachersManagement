using System;
using System.ComponentModel.DataAnnotations;

namespace TeachersManagementApp.Models.Domain
{
	public class Gender
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string GenderName { get; set; }
	}
}

