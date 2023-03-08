using System;
using TeachersManagementApp.Models.Domain;

namespace TeachersManagementApp.Repositories.Abstract
{
	public interface INationalityService
	{
		bool Add(Nationality model);

		bool Update(Nationality model);

		bool Delete(int id);

		Nationality FindById(int id);

		IEnumerable<Nationality> GetAll();
	}
}

