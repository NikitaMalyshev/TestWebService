namespace TestWebService.Data.DbInitialize.DTO;

using System.Collections.Generic;
using Model.CalculatingMeteringDevices;
using TestWebService.Model.ElectricalDevices.EnergyMeters;
using TestWebService.Model.ElectricalDevices.Transformers;
using TestWebService.Model.ElectricityConsumptionObjects;
using TestWebService.Model.ElectricityMeasuringPoints;
using TestWebService.Model.ElectricitySupplyPoints;
using TestWebService.Model.Organizations;

/// <summary>
/// Граф начальных тестовых данных для инициализации БД.
/// </summary>
public class TestDataGraph
{
    /// <summary>
    /// Инициализирует экземпляр <see cref="TestDataGraph"/>.
    /// </summary>
    public TestDataGraph()
    {
        Organizations = new List<Organization>();
        CalculatingMeteringDevices = new List<CalculatingMeteringDevice>();
        ElectricityConsumptionObjects = new List<ElectricityConsumptionObject>();
        ElectricityMeasuringPoints = new List<ElectricityMeasuringPoint>();
        ElectricitySupplyPoints = new List<ElectricitySupplyPoint>();
        EnergyMeters = new List<EnergyMeter>();
        Transformers = new List<Transformer>();
    }

    /// <summary>
    /// Получает коллекцию организаций.
    /// </summary>
    public ICollection<Organization> Organizations { get; private set; }

    /// <summary>
    /// Получает коллекцию объектов расчетных приборов учета.
    /// </summary>
    public ICollection<CalculatingMeteringDevice> CalculatingMeteringDevices { get; private set; }

    /// <summary>
    /// Получает коллекцию объектов потребления электроэнергии.
    /// </summary>
    public ICollection<ElectricityConsumptionObject> ElectricityConsumptionObjects { get; private set; }

    /// <summary>
    /// Получает коллекцию точек измерения электроэнергии.
    /// </summary>
    public ICollection<ElectricityMeasuringPoint> ElectricityMeasuringPoints { get; private set; }

    /// <summary>
    /// Получает коллекцию точек поставки электроэнергии.
    /// </summary>
    public ICollection<ElectricitySupplyPoint> ElectricitySupplyPoints { get; private set; }

    /// <summary>
    /// Получает коллекцию счетчиков электроэнергии.
    /// </summary>
    public ICollection<EnergyMeter> EnergyMeters { get; private set; }

    /// <summary>
    /// Получает коллекцию трансформаторов тока.
    /// </summary>
    public ICollection<Transformer> Transformers { get; private set; }
}