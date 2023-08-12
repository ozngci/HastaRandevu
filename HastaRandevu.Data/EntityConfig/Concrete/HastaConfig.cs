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
    public class HastaConfig : BaseConfig<Hasta>
    {
        public override void Configure(EntityTypeBuilder<Hasta> builder)
        {
            base.Configure(builder);
            builder.Property(x=>x.HastaAdi).HasMaxLength(50);
            builder.Property(x=>x.HastaSoyadi).HasMaxLength(50);

        }
    }
}
