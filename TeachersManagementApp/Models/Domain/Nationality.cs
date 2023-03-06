using System;
using System.ComponentModel.DataAnnotations;

namespace TeachersManagementApp.Models.Domain
{
	public class Nationality
	{
		public int Id { get; set; }

		[Required]
		public string NationalityName { get; set; }
	}
}
