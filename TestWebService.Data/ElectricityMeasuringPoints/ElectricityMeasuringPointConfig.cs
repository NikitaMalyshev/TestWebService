namespace TestWebService.Data.ElectricityMeasuringPoints;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestWebService.Model.ElectricityMeasuringPoints;

/// <summary>
/// Конфигурация сущности точки измерения электроэнергии.
/// </summary>
internal class ElectricityMeasuringPointConfig : IEntityTypeConfiguration<ElectricityMeasuringPoint>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<ElectricityMeasuringPoint> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).UseIdentityColumn();
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.EnergyMeterId).IsRequired();
        builder.Property(p => p.CurrentTransformerId).IsRequired();
        builder.Property(p => p.VoltageTransformerId).IsRequired();
        builder.Property(p => p.ElectricityConsumptionObjectId).IsRequired();
    }
}