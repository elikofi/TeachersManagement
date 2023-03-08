using System;
using TeachersManagementApp.Models.Domain;
using TeachersManagementApp.Repositories.Abstract;

namespace TeachersManagementApp.Repositories.Implementation
{
	public class NationalityService : INationalityService
	{
		private readonly DatabaseContext context;
		public NationalityService(DatabaseContext context)
		{
			this.context = context;
		}

        //Add method
        public bool Add(Nationality model)
        {
            try
            {
                context.Nationality.Add(model);
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
                context.Nationality.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public Nationality FindById(int id)
        {
            return context.Nationality.Find(id);
        }

        public IEnumerable<Nationality> GetAll()
        {
            return context.Nationality.ToList();
        }

        public bool Update(Nationality model)
        {
            try
            {
                context.Nationality.Update(model);
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

