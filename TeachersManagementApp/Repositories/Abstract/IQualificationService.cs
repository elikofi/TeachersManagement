using System;
using TeachersManagementApp.Models.Domain;

namespace TeachersManagementApp.Repositories.Abstract
{
	public interface IQualificationService
	{
		bool Add(Qualification model);

		bool Update(Qualification model);

		bool Delete(int id);

		Qualification FindById(int id);

		IEnumerable<Qualification> GetAll();
	}
}

