// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3
{
    // BitFiddlerCURRENCIES
    public class BitFiddlerCurrenCyConfiguration : IEntityTypeConfiguration<BitFiddlerCurrenCy>
    {
        public void Configure(EntityTypeBuilder<BitFiddlerCurrenCy> builder)
        {
            builder.ToTable("BitFiddlerCURRENCIES", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__BitFiddl__3214EC079C39E480").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
        }
    }

}
// </auto-generated>
