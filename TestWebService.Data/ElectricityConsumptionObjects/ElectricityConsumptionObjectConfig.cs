namespace TestWebService.Data.ElectricityConsumptionObjects;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestWebService.Model.ElectricityConsumptionObjects;

/// <summary>
/// Конфигурация сущности объекта потребления электроэнергии.
/// </summary>
internal class ElectricityConsumptionObjectConfig : IEntityTypeConfiguration<ElectricityConsumptionObject>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ElectricityConsumptionObject> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).UseIdentityColumn();
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.Address).IsRequired();
        builder.Property(p => p.OrganizationId).IsRequired();
    }
}