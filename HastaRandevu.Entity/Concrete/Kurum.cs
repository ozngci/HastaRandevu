using HastaRandevu.Entity.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevu.Entity.Concrete
{
    public class Kurum : BaseEntity
    {
        public string KurumAdi { get; set; }

        public ICollection<Doktor> Doktorlar { get; set; }
    }
}
