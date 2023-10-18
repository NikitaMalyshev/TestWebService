namespace TestWebService.Data.Context;

using System;
using CalculatingMeteringDevices;
using DbInitialize;
using ElectricalDevices.EnergyMeters;
using ElectricalDevices.Transformers;
using ElectricityConsumptionObjects;
using ElectricityMeasuringPoints;
using ElectricitySupplyPoints;
using Microsoft.EntityFrameworkCore;
using Model.CalculatingMeteringDevices;
using Model.ElectricalDevices.EnergyMeters;
using Model.ElectricalDevices.Transformers;
using Model.ElectricityConsumptionObjects;
using Model.ElectricityMeasuringPoints;
using Model.ElectricitySupplyPoints;
using Model.Organizations;
using Organizations;

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

    /// <summary>
    /// Получает или задает расчетные приборы учета.
    /// </summary>
    public DbSet<CalculatingMeteringDevice> CalculatingMeteringDevices { get; set; }

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
        modelBuilder.ApplyConfiguration(new CalculatingMeteringDeviceConfig());

        var dataGraph = _dbInitializer.GenerateTestData();

        modelBuilder.Entity<Organization>().HasData(dataGraph.Organizations);
        modelBuilder.Entity<CalculatingMeteringDevice>().HasData(dataGraph.CalculatingMeteringDevices);
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