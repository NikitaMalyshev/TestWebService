namespace TestWebService.Data.ElectricalDevices.EnergyMeters;

using TestWebService.Model.ElectricalDevices.EnergyMeters;
using TestWebService.Data.Repository;

/// <summary>
/// Интерфейс репозитория счетчиков электроэнергии.
/// </summary>
public interface IEnergyMeterRepository : IRepositoryBase<EnergyMeter>
{
}