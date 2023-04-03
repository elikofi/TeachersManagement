using System;
using System.ComponentModel.DataAnnotations;

namespace TeachersManagementApp.Models.Domain
{
	public class Qualification
	{
		[Key]
		public int Id { get; set; }

		[Required]
		public string? QualificationName { get; set; }
	}
}

