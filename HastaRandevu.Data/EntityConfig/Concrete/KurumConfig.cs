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
    public class KurumConfig : BaseConfig<Kurum>
    {
        public override void Configure(EntityTypeBuilder<Kurum> builder)
        {
            base.Configure(builder);
            builder.HasIndex(x => x.KurumAdi).IsUnique();
            builder.Property(x => x.KurumAdi).HasMaxLength(50);
        }
    }
}
