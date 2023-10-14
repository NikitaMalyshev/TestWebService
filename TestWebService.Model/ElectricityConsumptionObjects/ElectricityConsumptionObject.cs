namespace TestWebService.Model.ElectricityConsumptionObjects;

using System;
using System.Collections.Generic;
using TestWebService.Model.ElectricityMeasuringPoints;
using TestWebService.Model.ElectricitySupplyPoints;
using TestWebService.Model.Organizations;

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
    /// Получает или задает организацию.
    /// </summary>
    public virtual Organization Organization { get; set; } = null!;

    /// <summary>
    /// Получает или задает точки измерения электроэнергии.
    /// </summary>
    public ICollection<ElectricityMeasuringPoint> ElectricityMeasuringPoints { get; } = new List<ElectricityMeasuringPoint>();

    /// <summary>
    /// Получает или задает точки поставки электроэнергии.
    /// </summary>
    public ICollection<ElectricitySupplyPoint> ElectricitySupplyPoints { get; } = new List<ElectricitySupplyPoint>();
}