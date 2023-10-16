namespace TestWebService.Data.DbInitialize;

using System;
using System.Collections.Generic;
using TestWebService.Data.DbInitialize.DTO;
using TestWebService.Model.ElectricalDevices.EnergyMeters;
using TestWebService.Model.ElectricalDevices.Transformers;
using TestWebService.Model.ElectricityConsumptionObjects;
using TestWebService.Model.ElectricityMeasuringPoints;
using TestWebService.Model.ElectricitySupplyPoints;
using TestWebService.Model.Organizations;

/// <summary>
/// Инициализатор БД.
/// </summary>
public class DbInitializer : IDbInitializer
{
    /// <summary>
    /// Генератор случайных чисел.
    /// </summary>
    private readonly Random _random;

    /// <summary>
    /// Инициализирует экземпляр <see cref="DbInitializer"/>.
    /// </summary>
    public DbInitializer()
    {
        _random = new Random();
    }

    /// <inheritdoc />
    public TestDataGraph GenerateTestData()
    {
        var graph = new TestDataGraph();
        var parentOrganizationId = Guid.NewGuid();
        var childOrganizationId = Guid.NewGuid();

        var childOrganization = new Organization
        {
            Id = childOrganizationId,
            Name = "ChildOrganization",
            Address = "ChildOrganizationAddress",
            ParentOrganizationId = parentOrganizationId
        };

        var parentOrganization = new Organization
        {
            Id = parentOrganizationId,
            Name = "ParentOrganization",
            Address = "ParentOrganizationAddress"
        };

        graph.Organizations.Add(childOrganization);
        graph.Organizations.Add(parentOrganization);

        var electricityConsumptionObjectIds = new List<Guid> { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

        foreach (var electricityConsumptionObjectId in electricityConsumptionObjectIds)
        {
            var electricityConsumptionObject = new ElectricityConsumptionObject
            {
                Id = electricityConsumptionObjectId,
                Name = "ElectricityConsumptionObject_" + _random.Next(0, 1000),
                Address = "ElectricityConsumptionObjectAddress",
                OrganizationId = childOrganizationId
            };

            GenerateElectricityMeasuringPoint(graph, electricityConsumptionObjectId);
            GenerateElectricitySupplyPoint(graph, electricityConsumptionObjectId);

            graph.ElectricityConsumptionObjects.Add(electricityConsumptionObject);
        }

        return graph;
    }

    /// <summary>
    /// Генерирует коллекцию точек измерения электроэнергии.
    /// </summary>
    /// <param name="testDataGraph">Граф тестовых данных.</param>
    /// <param name="electricityConsumptionObjectId">Идентификатор объекта потребления электроэнергии.</param>
    private void GenerateElectricityMeasuringPoint(
        TestDataGraph testDataGraph,
        Guid electricityConsumptionObjectId)
    {
        if (testDataGraph == null)
            throw new ArgumentNullException(nameof(testDataGraph));

        var electricityMeasuringPointIds = new List<Guid> { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };
        foreach (var electricityMeasuringPointId in electricityMeasuringPointIds)
        {
            var energyMeter = new EnergyMeter
            {
                Id = Guid.NewGuid(),
                Number = _random.Next(0, 1000),
                Type = (MeterType)_random.Next(1, 3),
                VerificationDate = new DateTime(2023, 01, 01).AddDays(_random.Next(300))
            };
            var currentTransformer = new Transformer
            {
                Id = Guid.NewGuid(),
                Number = _random.Next(0, 1000),
                Type = TransformerType.Current,
                Subtype = (TransformerSubtype)_random.Next(1, 3),
                VerificationDate = new DateTime(2023, 01, 01).AddDays(_random.Next(300)),
                TransformationRatio = 1
            };
            var voltageTransformer = new Transformer
            {
                Id = Guid.NewGuid(),
                Number = _random.Next(0, 1000),
                Type = TransformerType.Voltage,
                Subtype = (TransformerSubtype)_random.Next(1, 3),
                VerificationDate = new DateTime(2023, 01, 01).AddDays(_random.Next(300)),
                TransformationRatio = 1
            };
            var electricityMeasuringPoint = new ElectricityMeasuringPoint
            {
                Id = electricityMeasuringPointId,
                Name = "ElectricityMeasuringPoint_" + _random.Next(0, 1000),
                EnergyMeterId = energyMeter.Id,
                CurrentTransformerId = currentTransformer.Id,
                VoltageTransformerId = voltageTransformer.Id,
                ElectricityConsumptionObjectId = electricityConsumptionObjectId
            };

            testDataGraph.EnergyMeters.Add(energyMeter);
            testDataGraph.Transformers.Add(currentTransformer);
            testDataGraph.Transformers.Add(voltageTransformer);
            testDataGraph.ElectricityMeasuringPoints.Add(electricityMeasuringPoint);
        }
    }

    /// <summary>
    /// Генерирует точку поставки электроэнергии.
    /// </summary>
    /// <param name="testDataGraph">Граф тестовых данных.</param>
    /// <param name="electricityConsumptionObjectId">Идентификатор объекта потребления электроэнергии.</param>
    private void GenerateElectricitySupplyPoint(
        TestDataGraph testDataGraph,
        Guid electricityConsumptionObjectId)
    {
        if (testDataGraph == null)
            throw new ArgumentNullException(nameof(testDataGraph));

        var electricitySupplyPoint = new ElectricitySupplyPoint
        {
            Id = Guid.NewGuid(),
            Name = "ElectricitySupplyPoint_" + _random.Next(0, 1000),
            MaxPower = _random.Next(0, 1000),
            ElectricityConsumptionObjectId = electricityConsumptionObjectId
        };

        testDataGraph.ElectricitySupplyPoints.Add(electricitySupplyPoint);
    }
}