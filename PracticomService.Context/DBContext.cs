using Microsoft.EntityFrameworkCore;
using PracticomService.Repositories.Entities;
using PracticomService.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticomService.Context
{
    public class DBContext : DbContext, IContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Child> Children { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=PracticomProjectData;Trusted_Connection=True;");
        }
    }
}
