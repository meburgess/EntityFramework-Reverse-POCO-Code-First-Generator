// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // User
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_User").ForSqlServerIsClustered();

            builder.Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseSqlServerIdentityColumn();
            builder.Property(x => x.ExternalUserId).HasColumnName(@"ExternalUserID").HasColumnType("varchar(50)").IsRequired(false).IsUnicode(false).HasMaxLength(50);
        }
    }

}
// </auto-generated>
