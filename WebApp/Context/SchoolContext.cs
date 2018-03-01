using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Context
{
    public class SchoolContext : DbContext
    {
        public static string connString = @"Server=.;Database=SchoolApp;Trusted_Connection=True;";
        public DbSet<Students> Students { get; set; }
        public DbSet<Subjects> Subjects { get; set; }

        public SchoolContext(): base(new DbContextOptionsBuilder<SchoolContext>().UseSqlServer(connString).Options)
        {

        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(connString);
        //}
    }
}
