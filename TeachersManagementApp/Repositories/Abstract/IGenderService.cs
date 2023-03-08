using System;
using TeachersManagementApp.Models.Domain;

namespace TeachersManagementApp.Repositories.Abstract
{
	public interface IGenderService
	{
		bool Add(Gender model);

		bool Update(Gender model);

		bool Delete(int id);

		Gender FindById(int id);

		IEnumerable<Gender> GetAll();
	}
}

