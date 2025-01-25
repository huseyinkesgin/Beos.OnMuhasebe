using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beos.OnMuhasebe.Configurations;
public static class OnMuhasebeDbContextModelBuilderExtentions
{
    public static void ConfigureBanka(this ModelBuilder builder)
    {
        builder.Entity<Banka>(b =>
        {
            b.ToTable("Bankalar");
            b.HasKey(x => x.Id);
            b.Property(x => x.Kod).HasMaxLength(50).IsRequired();
            b.Property(x => x.Ad).HasMaxLength(100).IsRequired();
            b.Property(x => x.Aciklama).HasMaxLength(500);
            b.HasOne(x => x.OzelKod1).WithMany().HasForeignKey(x => x.OzelKod1Id).OnDelete(DeleteBehavior.Restrict);
            b.HasOne(x => x.OzelKod2).WithMany().HasForeignKey(x => x.OzelKod2Id).OnDelete(DeleteBehavior.Restrict);
            b.HasMany(x => x.BankaSubeler).WithOne(x => x.Banka).HasForeignKey(x => x.BankaId).OnDelete(DeleteBehavior.Restrict);
            b.HasMany(x => x.MakbuzHareketler).WithOne(x => x.Banka).HasForeignKey(x => x.BankaId).OnDelete(DeleteBehavior.Restrict);
        });
    }
}
