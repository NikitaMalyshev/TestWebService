namespace TestWebService.Data.DbInitialize;

using System;
using System.Collections.Generic;
using DTO;
using Model.CalculatingMeteringDevices;
using Model.ElectricalDevices.EnergyMeters;
using Model.ElectricalDevices.Transformers;
using Model.ElectricityConsumptionObjects;
using Model.ElectricityMeasuringPoints;
using Model.ElectricitySupplyPoints;
using Model.Organizations;

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
        var parentOrganizationId = new Guid("B88D3F98-CCC2-47C8-AFCD-E8E5D8185F9E");
        var childOrganizationId = new Guid("2A9F49B7-FC3F-439C-88D6-FC79C9255E47");

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

        var electricityConsumptionObjectIds = new List<Guid>
        {
            new Guid("67FA82B4-F1CE-491F-BD98-3419D355EA53"),
            new Guid("38CE2462-C310-40B9-B6C5-4EAC8F011A4E"),
            new Guid("89ECC40B-F41E-4B10-AADB-9ABE2DDE40A7")
        };

        foreach (var electricityConsumptionObjectId in electricityConsumptionObjectIds)
        {
            var electricityConsumptionObject = new ElectricityConsumptionObject
            {
                Id = electricityConsumptionObjectId,
                Name = "ElectricityConsumptionObject_" + _random.Next(0, 1000),
                Address = "ElectricityConsumptionObjectAddress",
                OrganizationId = childOrganizationId
            };

            GeneratePoints(graph, electricityConsumptionObjectId);

            graph.ElectricityConsumptionObjects.Add(electricityConsumptionObject);
        }

        return graph;
    }

    /// <summary>
    /// Генерирует основные сущности.
    /// </summary>
    /// <param name="testDataGraph">Граф тестовых данных.</param>
    /// <param name="electricityConsumptionObjectId">Идентификатор объекта потребления электроэнергии.</param>
    private void GeneratePoints(
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
                VerificationDate = new DateTime(2023, 10, 01).AddDays(_random.Next(25))
            };
            var currentTransformer = new Transformer
            {
                Id = Guid.NewGuid(),
                Number = _random.Next(0, 1000),
                Type = TransformerType.Current,
                Subtype = (TransformerSubtype)_random.Next(1, 3),
                VerificationDate = new DateTime(2023, 10, 01).AddDays(_random.Next(25)),
                TransformationRatio = 1
            };
            var voltageTransformer = new Transformer
            {
                Id = Guid.NewGuid(),
                Number = _random.Next(0, 1000),
                Type = TransformerType.Voltage,
                Subtype = (TransformerSubtype)_random.Next(1, 3),
                VerificationDate = new DateTime(2023, 10, 01).AddDays(_random.Next(25)),
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
            var electricitySupplyPoint = new ElectricitySupplyPoint
            {
                Id = Guid.NewGuid(),
                Name = "ElectricitySupplyPoint_" + _random.Next(0, 1000),
                MaxPower = _random.Next(0, 1000),
                ElectricityConsumptionObjectId = electricityConsumptionObjectId
            };

            var startDate = new DateTime(_random.Next(2015, 2024), 01, 01);
            var calculatingMeteringDevice = new CalculatingMeteringDevice
            {
                ElectricityMeasuringPointId = electricityMeasuringPointId,
                ElectricitySupplyPointId = electricitySupplyPoint.Id,
                StartDate = startDate,
                EndDate = startDate.AddDays(_random.Next(365)),
            };

            testDataGraph.EnergyMeters.Add(energyMeter);
            testDataGraph.Transformers.Add(currentTransformer);
            testDataGraph.Transformers.Add(voltageTransformer);
            testDataGraph.ElectricityMeasuringPoints.Add(electricityMeasuringPoint);
            testDataGraph.ElectricitySupplyPoints.Add(electricitySupplyPoint);
            testDataGraph.CalculatingMeteringDevices.Add(calculatingMeteringDevice);
        }
    }
}