// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3
{
    // BITFIDDLERALLCAPS
    public class BitfiddlerallcapConfiguration : IEntityTypeConfiguration<Bitfiddlerallcap>
    {
        public void Configure(EntityTypeBuilder<Bitfiddlerallcap> builder)
        {
            builder.ToTable("BITFIDDLERALLCAPS", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__BITFIDDL__3214EC07D45E5E4C").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
        }
    }

}
// </auto-generated>
