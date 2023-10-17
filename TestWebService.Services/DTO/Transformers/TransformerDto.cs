namespace TestWebService.Services.DTO.Transformers;

using System;
using System.ComponentModel.DataAnnotations;
using JetBrains.Annotations;
using Model.ElectricalDevices.Transformers;

/// <summary>
/// Данные для создания трансформатора.
/// </summary>
[PublicAPI]
public class TransformerDto
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
    /// Получает или задает подтип трансформатора.
    /// </summary>
    [Required]
    public TransformerSubtype Subtype { get; set; }

    /// <summary>
    /// Получает или задает коэффициент трансформации.
    /// </summary>
    [Required]
    public float TransformationRatio { get; set; }
}