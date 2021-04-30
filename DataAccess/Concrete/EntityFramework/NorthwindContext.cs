using Entities.Concrete;
using Entities.Concrete.MusterilerClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        //DbContextOptionsBuilder
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server=sql107.epizy.com;
                                      Port=3306;
                                      Database=epiz_27976956_Car;
                                      Uid=epiz_27976956;
                                      Pwd=4lHguO8FnLaZWZ;"
                                    );
            
        }

        public DbSet<Musteriler> Musteriler { get; set; }
        public DbSet<Brand> Brandss { get; set; }
        public DbSet<Color> Colors { get; set; }

    }
}
