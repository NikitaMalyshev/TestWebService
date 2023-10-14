namespace TestWebService.Model.ElectricalDevices.Base;

using System;

/// <summary>
/// Модель базового электрического устройства.
/// </summary>
public class ElectricalDevice
{
    /// <summary>
    /// Получает или задает идентификатор устройства.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Получает или задает номер устройства.
    /// </summary>
    public int Number { get; set; }

    /// <summary>
    /// Получает или задает дату поверки устройства.
    /// </summary>
    public DateTime VerificationDate { get; set; }
}