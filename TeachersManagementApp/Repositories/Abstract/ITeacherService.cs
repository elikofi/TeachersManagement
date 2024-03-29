﻿using System;
using TeachersManagementApp.Models.Domain;

namespace TeachersManagementApp.Repositories.Abstract
{
	public interface ITeacherService
	{
        bool Add(Teacher model);

        bool Update(Teacher model);

        bool Delete(int id);

        Teacher FindById(int id);

        IEnumerable<Teacher> GetAll();

        IEnumerable<Teacher> GetBySearch();

        // have to add new things DateOnly GetDateOnly();

    }
}

