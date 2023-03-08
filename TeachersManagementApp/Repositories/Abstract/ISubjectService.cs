using System;
using TeachersManagementApp.Models.Domain;

namespace TeachersManagementApp.Repositories.Abstract
{
	public interface ISubjectService
	{
		bool Add(Subject model);

		bool Update(Subject model);

		bool Delete(int id);

		Subject FindById(int id);

		IEnumerable<Subject> GetAll();
	}
}

