// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Collections.Generic;

namespace V6EfrpgTest
{
    // table with space
    public class TableWithSpaceConfiguration : IEntityTypeConfiguration<TableWithSpace>
    {
        public void Configure(EntityTypeBuilder<TableWithSpace> builder)
        {
            builder.ToTable("table with space", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_TableWithSpace").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.HasMany<TableWithSpaceAndInColumn>(t => t.TableWithSpaceAndInColumns).WithMany(t => t.TableWithSpaces).UsingEntity<Dictionary<string, object>>("table mapping with space",
                    j => j.HasOne<TableWithSpaceAndInColumn>().WithMany().HasForeignKey("id value"),
                    j => j.HasOne<TableWithSpace>().WithMany().HasForeignKey("id"),
                    j => j.ToTable("table mapping with space", "dbo"));
        }
    }

}
// </auto-generated>
