namespace TestWebService.Model.CalculatingMeteringDevices;

using System;
using ElectricityMeasuringPoints;
using ElectricitySupplyPoints;

/// <summary>
/// Модель расчетного прибора учета.
/// </summary>
public class CalculatingMeteringDevice
{
    /// <summary>
    /// Получает или задает идентификатор точки измерения электроэнергии.
    /// </summary>
    public Guid ElectricityMeasuringPointId { get; set; }

    /// <summary>
    /// Получает или задает точку измерения электроэнергии.
    /// </summary>
    public ElectricityMeasuringPoint ElectricityMeasuringPoint { get; set; }

    /// <summary>
    /// Получает или задает идентификатор точки поставки электроэнергии.
    /// </summary>
    public Guid ElectricitySupplyPointId { get; set; }

    /// <summary>
    /// Получает или задает точку поставки электроэнергии.
    /// </summary>
    public ElectricitySupplyPoint ElectricitySupplyPoint { get; set; }

    /// <summary>
    /// Получает или задает начальную дату.
    /// </summary>
    public DateTime StartDate { get; set; }

    /// <summary>
    /// Получает или задает конечную дату.
    /// </summary>
    public DateTime EndDate { get; set; }
}