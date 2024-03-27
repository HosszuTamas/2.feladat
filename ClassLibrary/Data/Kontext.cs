using ClassLibrary.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Data
{
    public class Kontext:DbContext
    {
        public Kontext() 
        { 
        }

        public DbSet<Ember>Emberek { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //string connMsSql = "Server=(localdb)\\mssqllocaldb;Database=API.Data;Trusted_Connection=True;MultipleActiveResultSets=true";
            //optionsBuilder.UseSqlServer(connMsSql);

            string connMySql = "Server=127.0.0.1;User ID=root;Password=;Database=EgyAdatbazis";
            optionsBuilder.UseMySql(connMySql,ServerVersion.AutoDetect(connMySql));
        }
    }
}
