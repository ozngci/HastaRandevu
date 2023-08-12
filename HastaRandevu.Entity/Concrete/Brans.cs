using HastaRandevu.Entity.Abstract;

namespace HastaRandevu.Entity.Concrete
{
    public class Brans : BaseEntity
    {
        public string BransAdi { get; set; }
        public ICollection<Doktor> Doktorlar { get; set; }
    }
}