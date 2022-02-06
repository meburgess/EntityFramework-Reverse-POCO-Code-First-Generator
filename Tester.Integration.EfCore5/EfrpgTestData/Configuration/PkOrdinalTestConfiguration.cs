// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5EfrpgTest
{
    // pk_ordinal_test
    public class PkOrdinalTestConfiguration : IEntityTypeConfiguration<PkOrdinalTest>
    {
        public void Configure(EntityTypeBuilder<PkOrdinalTest> builder)
        {
            builder.ToTable("pk_ordinal_test", "dbo");
            builder.HasKey(x => new { x.C3, x.C1 }).HasName("PK__pk_ordin__1135D3B469FFB6F9").IsClustered();

            builder.Property(x => x.C1).HasColumnName(@"C1").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.C2).HasColumnName(@"C2").HasColumnType("int").IsRequired();
            builder.Property(x => x.C3).HasColumnName(@"C3").HasColumnType("int").IsRequired().ValueGeneratedNever();
        }
    }

}
// </auto-generated>
