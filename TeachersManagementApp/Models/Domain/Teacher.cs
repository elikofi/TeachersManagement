using System;
using System.ComponentModel.DataAnnotations;

namespace TeachersManagementApp.Models.Domain
{
	public class Teacher
	{
		public int Id { get; set; }
		[Required]
		public string Name { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string GenderId { get; set; }
        [Required]
        public string NationalityId { get; set; }
        [Required]
        public string SubjectId { get; set; }
        [Required]
        public string RoleId { get; set; }
        [Required]
        public string QualificationId { get; set; }

	}
}

