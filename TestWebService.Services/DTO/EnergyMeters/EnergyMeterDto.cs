namespace TestWebService.Services.DTO.EnergyMeters;

using System;
using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;
using Model.ElectricalDevices.EnergyMeters;

/// <summary>
/// Данные для создания счетчика электроэнергии.
/// </summary>
[PublicAPI]
public class EnergyMeterDto
{
    /// <summary>
    /// Получает или задает номер устройства.
    /// </summary>
    [Required]
    public int Number { get; set; }

    /// <summary>
    /// Получает или задает дату поверки устройства.
    /// </summary>
    [Required]
    public DateTime VerificationDate { get; set; }

    /// <summary>
    /// Получает или задает тип счетчика.
    /// </summary>
    [Required]
    public MeterType Type { get; set; }
}