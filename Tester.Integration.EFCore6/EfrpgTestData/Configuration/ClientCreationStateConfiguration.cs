// <auto-generated>

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace V6EfrpgTest
{
    // ClientCreationState
    public class ClientCreationStateConfiguration : IEntityTypeConfiguration<ClientCreationState>
    {
        public void Configure(EntityTypeBuilder<ClientCreationState> builder)
        {
            builder.ToTable("ClientCreationState", "dbo");
            builder.HasKey(x => x.Id).HasName("PK_ClientCreationState").IsClustered();

            builder.Property(x => x.Id).HasColumnName(@"id").HasColumnType("uniqueidentifier").IsRequired().ValueGeneratedNever();
            builder.Property(x => x.WebhookSetup).HasColumnName(@"WebhookSetup").HasColumnType("bit").IsRequired();
            builder.Property(x => x.AuthSetup).HasColumnName(@"AuthSetup").HasColumnType("bit").IsRequired();
            builder.Property(x => x.AssignedCarrier).HasColumnName(@"AssignedCarrier").HasColumnType("bit").IsRequired();
        }
    }

}
// </auto-generated>
