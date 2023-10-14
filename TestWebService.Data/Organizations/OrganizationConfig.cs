namespace TestWebService.Data.Organizations;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TestWebService.Model.Organizations;

/// <summary>
/// Конфигурация сущности организации.
/// </summary>
internal class OrganizationConfig : IEntityTypeConfiguration<Organization>
{
    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<Organization> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(p => p.Id).UseIdentityColumn();
        builder.Property(p => p.Name).IsRequired();
        builder.Property(p => p.Address).IsRequired();
        builder.Property(p => p.ParentOrganizationId).IsRequired();
    }
}