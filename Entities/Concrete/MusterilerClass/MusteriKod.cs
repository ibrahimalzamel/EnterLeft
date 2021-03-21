using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete.MusterilerClass
{
    public class MusteriKod : IEntity
    {
        public int MusteriKodID { get; set; }
        public string KodID { get; set; }
        public string IsimKod { get; set; }

    }
}
