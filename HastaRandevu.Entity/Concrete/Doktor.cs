using HastaRandevu.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevu.Entity.Concrete
{
    public class Doktor : BaseEntity
    {
        public string DoktorAdi { get; set; }
        public string DoktorSoyadi { get; set; }

        public int BransId { get; set; }
        public Brans DoktorBransi { get; set; }

        public ICollection<Kurum> Kurumlar { get; set; }
    }
}
