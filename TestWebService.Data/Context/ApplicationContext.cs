namespace TestWebService.Data.Context;

using System;
using TestWebService.Data.ElectricalDevices.EnergyMeters;
using TestWebService.Data.ElectricalDevices.Transformers;
using TestWebService.Data.ElectricityConsumptionObjects;
using TestWebService.Data.ElectricityMeasuringPoints;
using TestWebService.Data.ElectricitySupplyPoints;
using TestWebService.Data.Organizations;
using Microsoft.EntityFrameworkCore;
using TestWebService.Data.DbInitialize;
using TestWebService.Model.ElectricalDevices.EnergyMeters;
using TestWebService.Model.ElectricalDevices.Transformers;
using TestWebService.Model.ElectricityConsumptionObjects;
using TestWebService.Model.ElectricityMeasuringPoints;
using TestWebService.Model.ElectricitySupplyPoints;
using TestWebService.Model.Organizations;

/// <summary>
/// Контекст БД.
/// </summary>
public class ApplicationContext : DbContext
{
    /// <summary>
    /// Инициализатор БД.
    /// </summary>
    private readonly IDbInitializer _dbInitializer;

    /// <summary>
    /// Инициализирует экземпляр <see cref="ApplicationContext"/>.
    /// </summary>
    /// <param name="options">Опции контекста БД.</param>
    /// <param name="dbInitializer">Инициализатор БД.</param>
    public ApplicationContext(DbContextOptions options, IDbInitializer dbInitializer) : base(options)
    {
        _dbInitializer = dbInitializer;
        InitializeDb();
    }

    /// <summary>
    /// Получает или задает счетчики электроэнергии.
    /// </summary>
    public DbSet<EnergyMeter> EnergyMeters { get; set; }

    /// <summary>
    /// Получает или задает трансформаторы.
    /// </summary>
    public DbSet<Transformer> Transformers { get; set; }

    /// <summary>
    /// Получает или задает объекты потребления электроэнергии.
    /// </summary>
    public DbSet<ElectricityConsumptionObject> ElectricityConsumptionObjects { get; set; }

    /// <summary>
    /// Получает или задает точки измерения электроэнергии.
    /// </summary>
    public DbSet<ElectricityMeasuringPoint> ElectricityMeasuringPoints { get; set; }

    /// <summary>
    /// Получает или задает точки поставки электроэнергии.
    /// </summary>
    public DbSet<ElectricitySupplyPoint> ElectricitySupplyPoints { get; set; }

    /// <summary>
    /// Получает или задает организации.
    /// </summary>
    public DbSet<Organization> Organizations { get; set; }

    /// <inheritdoc />
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        if (modelBuilder == null)
            throw new ArgumentNullException(nameof(modelBuilder));

        modelBuilder.ApplyConfiguration(new OrganizationConfig());
        modelBuilder.ApplyConfiguration(new ElectricityConsumptionObjectConfig());
        modelBuilder.ApplyConfiguration(new ElectricityMeasuringPointConfig());
        modelBuilder.ApplyConfiguration(new ElectricitySupplyPointConfig());
        modelBuilder.ApplyConfiguration(new EnergyMeterConfig());
        modelBuilder.ApplyConfiguration(new TransformerConfig());

        var dataGraph = _dbInitializer.GenerateTestData();

        modelBuilder.Entity<Organization>().HasData(dataGraph.Organizations);
        modelBuilder.Entity<ElectricityConsumptionObject>().HasData(dataGraph.ElectricityConsumptionObjects);
        modelBuilder.Entity<ElectricityMeasuringPoint>().HasData(dataGraph.ElectricityMeasuringPoints);
        modelBuilder.Entity<ElectricitySupplyPoint>().HasData(dataGraph.ElectricitySupplyPoints);
        modelBuilder.Entity<EnergyMeter>().HasData(dataGraph.EnergyMeters);
        modelBuilder.Entity<Transformer>().HasData(dataGraph.Transformers);
    }

    /// <summary>
    /// Инициализирует БД тестовыми данными.
    /// </summary>
    private void InitializeDb()
    {
        Database.EnsureDeleted();
        Database.EnsureCreated();
    }
}