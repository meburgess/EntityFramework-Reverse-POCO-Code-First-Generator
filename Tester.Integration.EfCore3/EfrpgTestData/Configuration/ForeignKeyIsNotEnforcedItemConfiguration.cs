// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore3
{
    // ForeignKeyIsNotEnforcedItem
    public class ForeignKeyIsNotEnforcedItemConfiguration : IEntityTypeConfiguration<ForeignKeyIsNotEnforcedItem>
    {
        public void Configure(EntityTypeBuilder<ForeignKeyIsNotEnforcedItem> builder)
        {
            builder.ToTable("ForeignKeyIsNotEnforcedItem", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__ForeignK__3213E83F83599812").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseIdentityColumn();
            builder.Property(x => x.NullValue).HasColumnName(@"null_value").HasColumnType("int").IsRequired(false);
            builder.Property(x => x.NotNullValue).HasColumnName(@"not_null_value").HasColumnType("int").IsRequired();

            // Foreign keys
            builder.HasOne(a => a.ForeignKeyIsNotEnforced_NotNullValue).WithOne(b => b.ForeignKeyIsNotEnforcedItem_NotNullValue).HasPrincipalKey<ForeignKeyIsNotEnforced>(p => p.NotNullValue).HasForeignKey<ForeignKeyIsNotEnforcedItem>(c => c.NotNullValue).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ForeignKeyIsNotEnforcedItem_notnull_notnull");
            builder.HasOne(a => a.ForeignKeyIsNotEnforced_NullValue).WithOne(b => b.ForeignKeyIsNotEnforcedItem_NullValue).HasPrincipalKey<ForeignKeyIsNotEnforced>(p => p.NotNullValue).HasForeignKey<ForeignKeyIsNotEnforcedItem>(c => c.NullValue).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK_ForeignKeyIsNotEnforcedItem_null_notnull");

            builder.HasIndex(x => x.NotNullValue).HasName("UQ_ForeignKeyIsNotEnforcedItem_not_null_value").IsUnique();
            builder.HasIndex(x => x.NullValue).HasName("UQ_ForeignKeyIsNotEnforcedItem_null_value").IsUnique();
        }
    }

}
// </auto-generated>
