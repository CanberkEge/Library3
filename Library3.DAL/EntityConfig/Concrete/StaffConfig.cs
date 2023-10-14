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
    public class StaffConfig : BaseConfig<Staff>
        
    {
        public override void Configure(EntityTypeBuilder<Staff> builder)
        {
            base.Configure(builder);
            builder.Property(p=> p.StaffFirstName).HasMaxLength(50);
            builder.Property(p=> p.StaffLastName).HasMaxLength(50);
            
            builder.HasMany(p => p.Books).WithOne(s => s.Staff);
            builder.HasMany(r => r.Readers).WithMany(s => s.Staffs);


        }
    }
}
