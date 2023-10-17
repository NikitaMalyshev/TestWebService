namespace TestWebService.Data.ElectricalDevices.EnergyMeters;

using Context;
using Model.ElectricalDevices.EnergyMeters;
using Repository;

/// <summary>
/// Репозиторий счетчиков электроэнергии.
/// </summary>
public class EnergyMeterRepository : RepositoryBase<EnergyMeter>, IEnergyMeterRepository
{
    /// <summary>
    /// Инициализирует экземпляр <see cref="EnergyMeterRepository" />.
    /// </summary>
    /// <param name="applicationContext">Контекст БД.</param>
    public EnergyMeterRepository(ApplicationContext applicationContext) : base(applicationContext)
    {
    }
}