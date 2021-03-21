using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs.MusterilerClassDto
{
    public class MusterilerDetailDto : IDto
    {
        public string MusteriID { get; set; }
        public string KodID { get; set; }
        public string IsimKod { get; set; }
        public string MusteriName { get; set; }
        public string CompanyName { get; set; }
        public string Telefon { get; set; }
        public string Address { get; set; }
        public string DestenationPort { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
    }
}
