namespace TestWebService.Data.ElectricitySupplyPoints;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestWebService.Model.ElectricitySupplyPoints;

/// <summary>
/// Конфигурация сущности точки поставки электроэнергии.
/// </summary>
internal class ElectricitySupplyPointConfig : IEntityTypeConfiguration<ElectricitySupplyPoint>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ElectricitySupplyPoint> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.MaxPower).IsRequired();
        builder.Property(p => p.ElectricityConsumptionObjectId).IsRequired();
    }
}