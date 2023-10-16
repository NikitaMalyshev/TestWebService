namespace TestWebService.Model.ElectricalDevices.EnergyMeters;

/// <summary>
/// Типы счетчиков электроэнергии по принципу действия.
/// </summary>
public enum MeterType
{
    /// <summary>
    /// Индукционный.
    /// </summary>
    Induction = 1,

    /// <summary>
    /// Электронный (статический)
    /// </summary>
    Electricity = 2
}