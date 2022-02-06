// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using System.Collections.Generic;

namespace V6EfrpgTest
{
    // Car
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable("Car", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__Car__3214EC07B2FC5F30").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"Id").HasColumnType("int").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.PrimaryColourId).HasColumnName(@"PrimaryColourId").HasColumnType("int").IsRequired();
            builder.Property(x => x.CarMake).HasColumnName(@"CarMake").HasColumnType("varchar(255)").IsRequired().IsUnicode(false).HasMaxLength(255);
            builder.Property(x => x.ComputedColumn).HasColumnName(@"computed_column").HasColumnType("int").IsRequired(false).ValueGeneratedOnAddOrUpdate();
            builder.Property(x => x.ComputedColumnPersisted).HasColumnName(@"computed_column_persisted").HasColumnType("int").IsRequired().ValueGeneratedOnAddOrUpdate();

            // Foreign keys
            builder.HasOne(a => a.Colour).WithMany(b => b.Cars_PrimaryColourId).HasForeignKey(c => c.PrimaryColourId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("CarPrimaryColourFK");
            builder.HasMany<Colour>(t => t.Colours).WithMany(t => t.Cars_CarId).UsingEntity<Dictionary<string, object>>("CarToColour",
                    j => j.HasOne<Colour>().WithMany().HasForeignKey("ColourId"),
                    j => j.HasOne<Car>().WithMany().HasForeignKey("CarId"),
                    j => j.ToTable("CarToColour", "dbo"));
        }
    }

}
// </auto-generated>
