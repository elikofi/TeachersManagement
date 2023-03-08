using System;
using TeachersManagementApp.Models.Domain;
using TeachersManagementApp.Repositories.Abstract;

namespace TeachersManagementApp.Repositories.Implementation
{
	public class RoleService :IRoleService 
	{
		private readonly DatabaseContext context;

		public RoleService(DatabaseContext context)
		{
			this.context = context;
		}

        //Add method
        public bool Add(Role model)
        {
            try
            {
                context.Role.Add(model);
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
                var data = context.Role.Find(id);
                if (data == null) return false;
                context.Role.Remove(data);
                context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Find method
        public Role FindById(int id)
        {
            return context.Role.Find(id);
        }


        //Get all method
        public IEnumerable<Role> GetAll()
        {
            return context.Role.ToList();
        }

        //Update method
        public bool Update(Role model)
        {
            try
            {
                context.Role.Update(model);
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

