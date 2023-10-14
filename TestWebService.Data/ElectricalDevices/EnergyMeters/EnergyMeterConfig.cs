namespace TestWebService.Data.ElectricalDevices.EnergyMeters;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestWebService.Model.ElectricalDevices.EnergyMeters;

/// <summary>
/// Конфигурация сущности счетчика электроэнергии.
/// </summary>
internal class EnergyMeterConfig : IEntityTypeConfiguration<EnergyMeter>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<EnergyMeter> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).UseIdentityColumn();
        builder.Property(p => p.Number).IsRequired();
        builder.Property(p => p.VerificationDate).IsRequired().HasColumnType("date");
        builder.Property(p => p.Type).IsRequired().HasConversion<string>();
        builder.Property(p => p.ElectricityMeasuringPointId).IsRequired();
    }
}