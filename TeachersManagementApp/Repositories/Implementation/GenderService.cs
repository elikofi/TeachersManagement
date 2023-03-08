using System;
using TeachersManagementApp.Models.Domain;
using TeachersManagementApp.Repositories.Abstract;

namespace TeachersManagementApp.Repositories.Implementation
{
	public class GenderService : IGenderService
	{
        private readonly DatabaseContext context;


		public GenderService(DatabaseContext context)
		{
            this.context = context;
		}

        //Add method
        public bool Add(Gender model)
        {
            try
            {
                context.Gender.Add(model);
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
                context.Gender.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //find method
        public Gender FindById(int id)
        {
            return context.Gender.Find(id);
        }

        //Get all method
        public IEnumerable<Gender> GetAll()
        {
            return context.Gender.ToList(); 
        }


        //Update method
        public bool Update(Gender model)
        {
            try
            {
                context.Gender.Update(model);
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

