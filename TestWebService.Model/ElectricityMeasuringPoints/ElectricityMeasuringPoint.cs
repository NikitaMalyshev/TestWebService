namespace TestWebService.Model.ElectricityMeasuringPoints;

using System;
using TestWebService.Model.ElectricalDevices.EnergyMeters;
using TestWebService.Model.ElectricalDevices.Transformers;
using TestWebService.Model.ElectricityConsumptionObjects;

/// <summary>
/// Модель точки измерения электроэнергии.
/// </summary>
public class ElectricityMeasuringPoint
{
    /// <summary>
    /// Получает или задает идентификатор.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Получает или задает наименование.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Получает или задает идентификатор счетчика электроэнергии.
    /// </summary>
    public Guid EnergyMeterId { get; set; }

    /// <summary>
    /// Получает или задает счетчик электроэнергии.
    /// </summary>
    public EnergyMeter EnergyMeter { get; set; }

    /// <summary>
    /// Получает или задает идентификатор трансформатор тока.
    /// </summary>
    public Guid CurrentTransformerId { get; set; }

    /// <summary>
    /// Получает или задает трансформатор тока.
    /// </summary>
    public Transformer CurrentTransformer { get; set; }

    /// <summary>
    /// Получает или задает идентификатор трансформатор напряжения.
    /// </summary>
    public Guid VoltageTransformerId { get; set; }

    /// <summary>
    /// Получает или задает трансформатор напряжения.
    /// </summary>
    public Transformer VoltageTransformer { get; set; }

    /// <summary>
    /// Получает или задает идентификатор объекта потребления электроэнергии.
    /// </summary>
    public Guid ElectricityConsumptionObjectId { get; set; }

    /// <summary>
    /// Получает или задает объект потребления электроэнергии.
    /// </summary>
    public virtual ElectricityConsumptionObject ElectricityConsumptionObject { get; set; } = null!;
}