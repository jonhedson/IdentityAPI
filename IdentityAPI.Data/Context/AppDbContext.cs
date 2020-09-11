using IdentityAPI.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace IdentityAPI.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        protected AppDbContext()
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
            new Employee
            {
                EmployeeId = 1,
                Name = "Pedro",
                Department = Department.TI,
                Email = "email@email.com"
            });
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
