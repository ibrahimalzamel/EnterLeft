using Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Entities.Concrete.MusterilerClass
{
    public class Musteriler :IEntity
    {
        [Key]
        public int MusteriID { get; set; }
        public int MusteriKodID { get; set; }
        public string MusteriName { get; set; }
        public string CompanyName { get; set; }
        public string Telefon { get; set; }
        public string Address { get; set; }
        public string DestenationPort { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }



    }
}
