// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6EfrpgTest
{
    // BitFiddlerCATEGORIES
    public class BitFiddlerCategoRyConfiguration : IEntityTypeConfiguration<BitFiddlerCategoRy>
    {
        public void Configure(EntityTypeBuilder<BitFiddlerCategoRy> builder)
        {
            builder.ToTable("BitFiddlerCATEGORIES", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__BitFiddl__3214EC07D6C44E33").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
        }
    }

}
// </auto-generated>
