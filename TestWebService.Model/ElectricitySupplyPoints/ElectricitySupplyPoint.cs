namespace TestWebService.Model.ElectricitySupplyPoints;

using System;
using System.Collections.Generic;
using CalculatingMeteringDevices;
using ElectricityMeasuringPoints;
using JetBrains.Annotations;

/// <summary>
/// Модель точки поставки электроэнергии.
/// </summary>
[UsedImplicitly]
public class ElectricitySupplyPoint
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
    /// Получает или задает максимальную мощность, кВт.
    /// </summary>
    public int MaxPower { get; set; }

    /// <summary>
    /// Получает или задает идентификатор объекта потребления электроэнергии.
    /// </summary>
    public Guid ElectricityConsumptionObjectId { get; set; }

    /// <summary>
    /// Получает или задает точки измерения электроэнергии.
    /// </summary>
    public virtual ICollection<ElectricityMeasuringPoint> ElectricityMeasuringPoints { get; set; }

    /// <summary>
    /// Получает или задает расчетные приборы учета.
    /// </summary>
    public virtual ICollection<CalculatingMeteringDevice> CalculatingMeteringDevices { get; set; }
}