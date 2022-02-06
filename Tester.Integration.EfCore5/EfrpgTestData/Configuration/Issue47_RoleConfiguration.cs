// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V5EfrpgTest
{
    // Role
    public class Issue47_RoleConfiguration : IEntityTypeConfiguration<Issue47_Role>
    {
        public void Configure(EntityTypeBuilder<Issue47_Role> builder)
        {
            builder.ToTable("Role", "Issue47");
            builder.HasKey(x => x.RoleId).HasName("PK__Role__8AFACE1A9BF4E70F").IsClustered();

            builder.Property(x => x.RoleId).HasColumnName(@"RoleId").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.Role).HasColumnName(@"Role").HasColumnType("varchar(10)").IsRequired(false).IsUnicode(false).HasMaxLength(10);
        }
    }

}
// </auto-generated>
