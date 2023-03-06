using System;
using System.ComponentModel.DataAnnotations;

namespace TeachersManagementApp.Models.Domain
{
	public class Subject
	{
		public int Id { get; set; }

		[Required]
		public string SubjectName { get; set; }
	}
}

