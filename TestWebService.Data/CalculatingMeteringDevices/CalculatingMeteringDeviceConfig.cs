namespace TestWebService.Data.CalculatingMeteringDevices;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.CalculatingMeteringDevices;

/// <summary>
/// Конфигурация сущности расчетного прибора учета.
/// </summary>
internal class CalculatingMeteringDeviceConfig : IEntityTypeConfiguration<CalculatingMeteringDevice>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<CalculatingMeteringDevice> builder)
    {
        builder.HasKey(p => new
            {
                p.ElectricityMeasuringPointId,
                p.ElectricitySupplyPointId,
                p.StartDate,
                p.EndDate
            });

        builder
            .HasOne(p => p.ElectricityMeasuringPoint)
            .WithMany(p => p.CalculatingMeteringDevices)
            .HasForeignKey(p => p.ElectricityMeasuringPointId)
            .OnDelete(DeleteBehavior.NoAction);

        builder
            .HasOne(p => p.ElectricitySupplyPoint)
            .WithMany(p => p.CalculatingMeteringDevices)
            .HasForeignKey(p => p.ElectricitySupplyPointId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}