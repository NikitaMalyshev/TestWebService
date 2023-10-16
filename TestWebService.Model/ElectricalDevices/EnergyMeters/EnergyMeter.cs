namespace TestWebService.Model.ElectricalDevices.EnergyMeters;

using TestWebService.Model.ElectricalDevices.Base;

/// <summary>
/// Модель счетчика электроэнергии.
/// </summary>
public class EnergyMeter : ElectricalDevice
{
    /// <summary>
    /// Получает или задает тип счетчика.
    /// </summary>
    public MeterType Type { get; set; }
}