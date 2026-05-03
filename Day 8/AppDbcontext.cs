using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Microsoft.EntityFrameworkCore;
namespace DotNet_task1
{
    internal class appdbcontext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=Levmzbygrb;Trusted_Connection=True; TrustServerCertificate=True;");

        }
        public DbSet<Student> Students { get; set; }

    }
}
