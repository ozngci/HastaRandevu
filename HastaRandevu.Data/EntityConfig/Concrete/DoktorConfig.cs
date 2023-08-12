using HastaRandevu.Data.EntityConfig.Abstract;
using HastaRandevu.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaRandevu.Data.EntityConfig.Concrete
{
    public class DoktorConfig : BaseConfig<Doktor>
    {
        public override void Configure(EntityTypeBuilder<Doktor> builder)
        {
            base.Configure(builder);
            builder.Property(x=>x.DoktorAdi).HasMaxLength(50);
            builder.Property(x=>x.DoktorSoyadi).HasMaxLength(50);
        }
    }
}
