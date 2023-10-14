namespace TestWebService.Data.ElectricalDevices.Transformers;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestWebService.Model.ElectricalDevices.Transformers;

/// <summary>
/// Конфигурация сущности трансформатора.
/// </summary>
internal class TransformerConfig : IEntityTypeConfiguration<Transformer>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<Transformer> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).UseIdentityColumn();
        builder.Property(p => p.Number).IsRequired();
        builder.Property(p => p.Type).IsRequired().HasConversion<string>();
        builder.Property(p => p.Subtype).IsRequired().HasConversion<string>();
        builder.Property(p => p.TransformationRatio).IsRequired();
        builder.Property(p => p.VerificationDate).IsRequired().HasColumnType("date");
        builder.Property(p => p.ElectricityMeasuringPointId).IsRequired();
    }
}