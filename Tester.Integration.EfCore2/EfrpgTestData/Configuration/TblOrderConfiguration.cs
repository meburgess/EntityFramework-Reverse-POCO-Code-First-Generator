// <auto-generated>
// ReSharper disable All

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Tester.Integration.EfCore2
{
    // tblOrders
    public class TblOrderConfiguration : IEntityTypeConfiguration<TblOrder>
    {
        public void Configure(EntityTypeBuilder<TblOrder> builder)
        {
            builder.ToTable("tblOrders", "dbo");
            builder.HasKey(x => x.Id).HasName("PK__tblOrder__3214EC276F4A5FCC").ForSqlServerIsClustered();

            builder.Property(x => x.Id).HasColumnName(@"ID").HasColumnType("int").IsRequired().ValueGeneratedOnAdd().UseSqlServerIdentityColumn();
            builder.Property(x => x.Added).HasColumnName(@"added").HasColumnType("datetime").IsRequired();
        }
    }

}
// </auto-generated>
