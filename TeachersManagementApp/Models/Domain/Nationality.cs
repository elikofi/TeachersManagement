using System;
using System.ComponentModel.DataAnnotations;

namespace TeachersManagementApp.Models.Domain
{
	public class Nationality
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string? NationalityName { get; set; }
	}
}
