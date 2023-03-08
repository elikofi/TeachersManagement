using System;
using TeachersManagementApp.Models.Domain;
using TeachersManagementApp.Repositories.Abstract;

namespace TeachersManagementApp.Repositories.Implementation
{
	public class SubjectService : ISubjectService
	{
		private readonly DatabaseContext context;

		public SubjectService(DatabaseContext context)
		{
			this.context = context;
		}

        //Add method
        public bool Add(Subject model)
        {
            try
            {
                context.Subject.Add(model);
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
                context.Subject.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Find method
        public Subject FindById(int id)
        {
            return context.Subject.Find(id);
        }

        //Get all method
        public IEnumerable<Subject> GetAll()
        {
            return context.Subject.ToList();
        }

        //Update method
        public bool Update(Subject model)
        {
            try
            {
                context.Subject.Update(model);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

