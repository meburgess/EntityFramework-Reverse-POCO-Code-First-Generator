// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3
{
    // TableWithSpaceInColumnOnly
    public class TableWithSpaceInColumnOnlyConfiguration : IEntityTypeConfiguration<TableWithSpaceInColumnOnly>
    {
        public void Configure(EntityTypeBuilder<TableWithSpaceInColumnOnly> builder)
        {
            builder.ToTable("TableWithSpaceInColumnOnly", "dbo");
            builder.HasKey(x => x.IdValue).HasName("PK_TableWithSpaceInColumnOnly").IsClustered();

            builder.Property(x => x.IdValue).HasColumnName(@"id value").HasColumnType("int").IsRequired().ValueGeneratedNever();
        }
    }

}
// </auto-generated>
