namespace TestWebService.Model.ElectricalDevices.EnergyMeters;

using System;
using TestWebService.Model.ElectricalDevices.Base;
using TestWebService.Model.ElectricityMeasuringPoints;

/// <summary>
/// Модель счетчика электроэнергии.
/// </summary>
public class EnergyMeter : ElectricalDevice
{
    /// <summary>
    /// Получает или задает тип счетчика.
    /// </summary>
    public MeterTypes Type { get; set; }

    /// <summary>
    /// Получает или задает идентификатор точки измерения электроэнергии.
    /// </summary>
    public Guid ElectricityMeasuringPointId { get; set; }

    /// <summary>
    /// Получает или задает точку измерения электроэнергии.
    /// </summary>
    public virtual ElectricityMeasuringPoint ElectricityMeasuringPoint { get; set; }
}