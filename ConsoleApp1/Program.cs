using DataAccess.Concrete.EntityFramework;
using Entities.Concrete.MusterilerClass;
using System;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (NorthwindContext db = new NorthwindContext())
            {
                db.Musteriler.Add(new Musteriler
                {
                    MusteriID = 1,
                    Address = "addr",
                    CompanyName = "com",
                    MusteriName = "name",
                    Country = "con",
                    MusteriKodID = 53543,
                    Telefon = "asdfasdf",
                    Email = "aksfkl",
                    DestenationPort = "asdflkjasdf"
                }) ;
            }
        }
    }
}
