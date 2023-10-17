namespace TestWebService.Data.ElectricalDevices.EnergyMeters;

using TestWebService.Data.Context;
using TestWebService.Model.ElectricalDevices.EnergyMeters;
using TestWebService.Data.Repository;

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