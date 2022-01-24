// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EFCore6.Single_context_many_files
{
    // BatchTest
    public class BatchTestConfiguration : IEntityTypeConfiguration<BatchTest>
    {
        public void Configure(EntityTypeBuilder<BatchTest> builder)
        {
            builder.ToTable("BatchTest", "dbo");
            builder.HasKey(x => x.Code).HasName("PK__BatchTes__357D4CF8B8A16F6F").IsClustered();

            builder.Property(x => x.Code).HasColumnName(@"code").HasColumnType("nvarchar(8)").IsRequired().HasMaxLength(8).ValueGeneratedNever();
        }
    }

}
// </auto-generated>