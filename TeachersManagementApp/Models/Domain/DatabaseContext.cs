using System;
using Microsoft.EntityFrameworkCore;

namespace TeachersManagementApp.Models.Domain
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options): base (options)
		{

		}

		public DbSet<Gender> Gender { get; set; }

        public DbSet<Nationality> Nationality { get; set; }

        public DbSet<Subject> Subject { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<Qualification> Qualification { get; set; }

        public DbSet<Teacher> Teacher { get; set; }
    }
}

