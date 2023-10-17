namespace TestWebService.Services.DTO.ElectricityMeasuringPoints;

using System;
using System.ComponentModel.DataAnnotations;
using EnergyMeters;
using JetBrains.Annotations;
using Transformers;

/// <summary>
/// Данные для создания новой точки измерения электроэнергии.
/// </summary>
[PublicAPI]
public class CreatePointDto
{
    /// <summary>
    /// Получает или задает наименование.
    /// </summary>
    [Required]
    public string Name { get; set; }

    /// <summary>
    /// Получает или задает счетчик электроэнергии.
    /// </summary>
    [Required]
    public virtual EnergyMeterDto EnergyMeter { get; set; }

    /// <summary>
    /// Получает или задает трансформатор тока.
    /// </summary>
    [Required]
    public virtual TransformerDto CurrentTransformer { get; set; }

    /// <summary>
    /// Получает или задает трансформатор напряжения.
    /// </summary>
    [Required]
    public virtual TransformerDto VoltageTransformer { get; set; }

    /// <summary>
    /// Получает или задает идентификатор объекта потребления электроэнергии.
    /// </summary>
    [Required]
    public Guid ElectricityConsumptionObjectId { get; set; }
}