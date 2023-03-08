using System;
using TeachersManagementApp.Models.Domain;

namespace TeachersManagementApp.Repositories.Abstract
{
	public interface IRoleService
	{
		bool Add(Role model);

		bool Update(Role model);

		bool Delete(int id);

		Role FindById(int id);

		IEnumerable<Role> GetAll();
	}
}

