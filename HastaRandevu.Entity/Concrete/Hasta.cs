using HastaRandevu.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevu.Entity.Concrete
{
    public class Hasta : BaseEntity
    {
        public string HastaAdi { get; set; }
        public string HastaSoyadi { get; set; }
    }
}
