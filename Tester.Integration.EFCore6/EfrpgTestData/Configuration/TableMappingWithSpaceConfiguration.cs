// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6EfrpgTest
{
    // table mapping with space
    public class TableMappingWithSpaceConfiguration : IEntityTypeConfiguration<TableMappingWithSpace>
    {
        public void Configure(EntityTypeBuilder<TableMappingWithSpace> builder)
        {
            builder.ToTable("table mapping with space", "dbo");
            builder.HasKey(x => new { x.Id, x.IdValue }).HasName("PK_TableMappingWithSpace").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.IdValue).HasColumnName(@"id value").HasColumnType("int").IsRequired().ValueGeneratedNever();
        }
    }

}
// </auto-generated>
