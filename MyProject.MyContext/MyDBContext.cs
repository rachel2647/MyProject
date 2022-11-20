using Microsoft.EntityFrameworkCore;
using MyProject.Repositories.Entities;
using System;

namespace MyProject.MyContext
{
    public class MyDBContext
    {
        public DbSet<Role> Roles { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server = (localdb)\\mssqllocaldb; Database = MyProjectDb; Trusted_Connection = True");
        }
    }
}
