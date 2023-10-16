namespace TestWebService.Model.ElectricalDevices.Transformers;

using TestWebService.Model.ElectricalDevices.Base;

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
}