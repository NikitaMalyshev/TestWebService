namespace TestWebService.Model.ElectricityConsumptionObjects;

using System;
using System.Collections.Generic;
using TestWebService.Model.ElectricityMeasuringPoints;
using TestWebService.Model.ElectricitySupplyPoints;

/// <summary>
/// Модель объекта потребления электроэнергии.
/// </summary>
public class ElectricityConsumptionObject
{
    /// <summary>
    /// Получает или задает идентификатор объекта.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Получает или задает наименование объекта.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Получает или задает адрес объекта.
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// Получает или задает идентификатор организации.
    /// </summary>
    public Guid OrganizationId { get; set; }

    /// <summary>
    /// Получает или задает точки измерения электроэнергии.
    /// </summary>
    public virtual ICollection<ElectricityMeasuringPoint> ElectricityMeasuringPoints { get; set; }

    /// <summary>
    /// Получает или задает точки поставки электроэнергии.
    /// </summary>
    public virtual ICollection<ElectricitySupplyPoint> ElectricitySupplyPoints { get; set; }
}