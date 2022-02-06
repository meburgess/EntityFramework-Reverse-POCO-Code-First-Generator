// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // tblOrderLines
    public class TblOrderLineConfiguration : IEntityTypeConfiguration<TblOrderLine>
    {
        public void Configure(EntityTypeBuilder<TblOrderLine> builder)
        {
            builder.ToTable("tblOrderLines", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__tblOrder__3214EC27CB4CFC88").ForSqlServerIsClustered();

            builder.Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseSqlServerIdentityColumn();
            builder.Property(x => x.OrderId).HasColumnName(@"OrderID").HasColumnType("int").IsRequired();
            builder.Property(x => x.Sku).HasColumnName(@"sku").HasColumnType("varchar(15)").IsRequired(false).IsUnicode(false).HasMaxLength(15);

            // Foreign keys
            builder.HasOne(a => a.TblOrder).WithMany(b => b.TblOrderLines).HasForeignKey(c => c.OrderId).OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("tblOrdersFK");
        }
    }

}
// </auto-generated>
