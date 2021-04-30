using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.MusterilerClass;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            Add(new Brand { BrandId = 21, BrandName = "iboo" });
        }
        public static List<Brand> Brands(Expression<Func<Brand, bool>> filter = null)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                return filter == null
                    ? context.Set<Brand>().ToList()
                    : context.Set<Brand>().Where(filter).ToList();
            }
        }
        public static void Add(Brand entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public static void Delete(Brand entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
   

}
