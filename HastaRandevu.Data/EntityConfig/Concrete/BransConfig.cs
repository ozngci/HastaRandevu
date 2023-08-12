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
    public class BransConfig : BaseConfig<Brans>
    {
        public override void Configure(EntityTypeBuilder<Brans> builder)
        {
            base.Configure(builder);
            builder.Property(x => x.BransAdi).HasMaxLength(50);
            builder.HasIndex(x => x.BransAdi).IsUnique();
        }
    }
}
