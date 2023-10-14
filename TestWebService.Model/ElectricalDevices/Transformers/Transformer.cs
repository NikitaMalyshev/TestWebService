namespace TestWebService.Model.ElectricalDevices.Transformers;

using System;
using TestWebService.Model.ElectricalDevices.Base;
using TestWebService.Model.ElectricityMeasuringPoints;

/// <summary>
/// Модель трансформатора.
/// </summary>
public class Transformer : ElectricalDevice
{
    /// <summary>
    /// Получает или задает тип трансформатора.
    /// </summary>
    public TransformerType Type { get; set; }

    /// <summary>
    /// Получает или задает подтип трансформатора.
    /// </summary>
    public TransformerSubtype Subtype { get; set; }

    /// <summary>
    /// Получает или задает коэффициент трансформации.
    /// </summary>
    public float TransformationRatio { get; set; }

    /// <summary>
    /// Получает или задает идентификатор точки измерения электроэнергии.
    /// </summary>
    public Guid ElectricityMeasuringPointId { get; set; }

    /// <summary>
    /// Получает или задает точку измерения электроэнергии.
    /// </summary>
    public virtual ElectricityMeasuringPoint ElectricityMeasuringPoint { get; set; }
}