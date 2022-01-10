// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5Fred
{
    // EnumsWithStringAsValue
    public class EnumsWithStringAsValueConfiguration : IEntityTypeConfiguration<EnumsWithStringAsValue>
    {
        public void Configure(EntityTypeBuilder<EnumsWithStringAsValue> builder)
        {
            builder.ToTable("EnumsWithStringAsValue", "dbo");
            builder.HasKey(x => new { x.EnumName, x.Value });

            builder.Property(x => x.EnumName).HasColumnName(@"enum_name").HasColumnType("varchar(50)").IsRequired().IsUnicode(false).HasMaxLength(50).ValueGeneratedNever();
            builder.Property(x => x.Value).HasColumnName(@"value").HasColumnType("varchar(10)").IsRequired().IsUnicode(false).HasMaxLength(10).ValueGeneratedNever();
        }
    }

}
// </auto-generated>