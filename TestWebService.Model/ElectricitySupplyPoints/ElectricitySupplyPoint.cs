namespace TestWebService.Model.ElectricitySupplyPoints;

using System;
using TestWebService.Model.ElectricityConsumptionObjects;

/// <summary>
/// Модель точки поставки электроэнергии.
/// </summary>
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
    /// Получает или задает объект потребления электроэнергии.
    /// </summary>
    public virtual ElectricityConsumptionObject ElectricityConsumptionObject { get; set; }
}