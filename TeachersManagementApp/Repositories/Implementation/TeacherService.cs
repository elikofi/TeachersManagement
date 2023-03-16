using System;
using TeachersManagementApp.Models.Domain;
using TeachersManagementApp.Repositories.Abstract;

namespace TeachersManagementApp.Repositories.Implementation
{
	public class TeacherService : ITeacherService
	{
        private readonly DatabaseContext context;


        public TeacherService(DatabaseContext context)
        {
            this.context = context;
        }

        //Add method
        public bool Add(Teacher model)
        {
            try
            {
                context.Teacher.Add(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Delete method
        public bool Delete(int id)
        {
            try
            {
                var data = this.FindById(id);
                if (data == null) return false;
                context.Teacher.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //find method
        public Teacher FindById(int id)
        {
            return context.Teacher.Find(id);
        }

        //Get all method
        public IEnumerable<Teacher> GetAll()
        {
            var data = (from teacher in context.Teacher
                        join subject in context.Subject
                        on teacher.SubjectId equals subject.Id
                        join nationality in context.Nationality on teacher.NationalityId equals nationality.Id
                        join gender in context.Gender on teacher.GenderId equals gender.Id
                        join role in context.Role on teacher.RoleId equals role.Id
                        join qualification in context.Qualification on teacher.QualificationId equals qualification.Id
                        select new Teacher
                        {
                            Id = teacher.Id,
                            SubjectId = teacher.SubjectId,
                            NationalityId = teacher.NationalityId,
                            GenderId = teacher.GenderId,
                            RoleId = teacher.RoleId,
                            QualificationId = teacher.QualificationId,
                            Name = teacher.Name,
                            Age = teacher.Age,
                            SubjectName = subject.SubjectName,
                            NationalityName = nationality.NationalityName,
                            GenderName = gender.GenderName,
                            RoleName = role.RoleName,
                            QualificationName = qualification.QualificationName
                        }
                        ).ToList();
            return data;
        }


        //Update method
        public bool Update(Teacher model)
        {
            try
            {
                context.Teacher.Update(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public IEnumerable<Teacher> GetBySearch()
        {
            var result = (from teacher in context.Teacher
                        join subject in context.Subject
                        on teacher.SubjectId equals subject.Id
                        join nationality in context.Nationality on teacher.NationalityId equals nationality.Id
                        join gender in context.Gender on teacher.GenderId equals gender.Id
                        join role in context.Role on teacher.RoleId equals role.Id
                        join qualification in context.Qualification on teacher.QualificationId equals qualification.Id
                        select new Teacher
                        {
                            Id = teacher.Id,
                            SubjectId = teacher.SubjectId,
                            NationalityId = teacher.NationalityId,
                            GenderId = teacher.GenderId,
                            RoleId = teacher.RoleId,
                            QualificationId = teacher.QualificationId,
                            Name = teacher.Name,
                            Age = teacher.Age,
                            SubjectName = subject.SubjectName,
                            NationalityName = nationality.NationalityName,
                            GenderName = gender.GenderName,
                            RoleName = role.RoleName,
                            QualificationName = qualification.QualificationName
                        }
                        ).ToList();
            return result;
        }
    }
}

