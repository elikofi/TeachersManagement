using System;
using TeachersManagementApp.Models.Domain;
using TeachersManagementApp.Repositories.Abstract;

namespace TeachersManagementApp.Repositories.Implementation
{
	public class QualificationService : IQualificationService
	{
		private readonly DatabaseContext context;

		public QualificationService(DatabaseContext context)
		{
			this.context = context;
		}

        //Add method
        public bool Add(Qualification model)
        {
            try
            {
                context.Qualification.Add(model);
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
                context.Qualification.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Qualification FindById(int id)
        {
            return context.Qualification.Find(id);
        }

        public IEnumerable<Qualification> GetAll()
        {
            return context.Qualification.ToList();
        }

        public bool Update(Qualification model)
        {
            try
            {
                context.Qualification.Update(model);
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

