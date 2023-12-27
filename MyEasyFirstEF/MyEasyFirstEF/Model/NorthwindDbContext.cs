using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyEasyFirstEF.Model
{
    public class NorthwindDbContext : DbContext
    {
        public DbSet<SysdataEntity> SysdataEntities { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //sql 連線字串 
            string conntionString = "Data Source=192.168.99.24;Initial Catalog=Northwind;User ID=pcteamdeveloper;Password=pcteamdeveloper;Application Name=ToulinTest";
            optionsBuilder.UseSqlServer(conntionString);
        }
    }
}
