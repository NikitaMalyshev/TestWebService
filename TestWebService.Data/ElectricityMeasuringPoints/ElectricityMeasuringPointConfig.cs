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
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.ElectricityConsumptionObjectId).IsRequired();

        builder
            .HasOne(p => p.EnergyMeter)
            .WithOne()
            .HasForeignKey<ElectricityMeasuringPoint>(p => p.EnergyMeterId);

        builder
            .HasOne(p => p.CurrentTransformer)
            .WithOne()
            .HasForeignKey<ElectricityMeasuringPoint>(p => p.CurrentTransformerId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.VoltageTransformer)
            .WithOne()
            .HasForeignKey<ElectricityMeasuringPoint>(p => p.VoltageTransformerId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}