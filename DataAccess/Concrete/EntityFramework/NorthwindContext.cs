using Entities.Concrete.MusterilerClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(@"Server=sql107.epizy.com;
                                      Port=3306;
                                      Database=epiz_27976956_test;
                                      Uid=epiz_27976956;
                                      Pwd=4lHguO8FnLaZWZ;");
        }

        public DbSet<Musteriler> Musteriler { get; set; }

    }
}
