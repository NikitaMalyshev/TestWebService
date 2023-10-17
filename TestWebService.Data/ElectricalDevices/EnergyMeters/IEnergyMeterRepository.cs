namespace TestWebService.Data.ElectricalDevices.EnergyMeters;

using Model.ElectricalDevices.EnergyMeters;
using Repository;

/// <summary>
/// Интерфейс репозитория счетчиков электроэнергии.
/// </summary>
public interface IEnergyMeterRepository : IRepositoryBase<EnergyMeter>
{
}