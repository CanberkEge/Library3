using Library3.DAL.EntityConfig.Abstract;
using Library3.Entity.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library3.DAL.EntityConfig.Concrete
{
    public class ReaderConfig : BaseConfig<Reader>

    {
        public override void Configure(EntityTypeBuilder<Reader> builder)
        {
            base.Configure(builder);
            builder.Property(p=> p.ReaderFirsName).HasMaxLength(256);
            builder.Property(p=> p.ReaderLastName).HasMaxLength(256);
            builder.Property(p=> p.Adress).HasMaxLength(512);
            builder.Property(p=> p.Email).HasMaxLength(100);
            
            builder.HasMany(p => p.Books).WithOne(r => r.Reader);
            builder.HasMany(s => s.Staffs).WithMany(r => r.Readers);

        }
    }
}
