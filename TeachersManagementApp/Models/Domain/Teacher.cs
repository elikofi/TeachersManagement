using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TeachersManagementApp.Models.Domain
{
	public class Teacher
	{
        [Key]
		public int Id { get; set; }

		[Required]
		public string? Name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public int SubjectId { get; set; }

        [Required]
        public int NationalityId { get; set; }

        [Required]
        public int GenderId { get; set; }

        [Required]
        public int RoleId { get; set; }

        [Required]
        public int QualificationId { get; set; }

        [Required]
        public DateOnly StartingDate { get; set; } //add time spent in the school model.



        [NotMapped]
        public string ? SubjectName { get; set; }

        [NotMapped]
        public string ? NationalityName { get; set; }

        [NotMapped]
        public string ? GenderName { get; set; }

        [NotMapped]
        public string ? RoleName { get; set; }

        [NotMapped]
        public string ? QualificationName { get; set; }

        [NotMapped]
        public List<SelectListItem> ? SubjectList { get; set; }

        [NotMapped]
        public List<SelectListItem> ? NationalityList { get; set; }

        [NotMapped]
        public List<SelectListItem> ? GenderList { get; set; }

        [NotMapped]
        public List<SelectListItem> ? RoleList { get; set; }

        [NotMapped]
        public List<SelectListItem> ? QualificationList { get; set; }
    }
}

