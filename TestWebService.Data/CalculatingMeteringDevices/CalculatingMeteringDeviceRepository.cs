namespace TestWebService.Data.CalculatingMeteringDevices;

using Context;
using Model.CalculatingMeteringDevices;
using Repository;

/// <summary>
/// Репозиторий расчетных приборов учета.
/// </summary>
public class CalculatingMeteringDeviceRepository :
    RepositoryBase<CalculatingMeteringDevice>,
    ICalculatingMeteringDeviceRepository
{
    /// <summary>
    /// Инициализирует экземпляр <see cref="CalculatingMeteringDeviceRepository" />.
    /// </summary>
    /// <param name="applicationContext">Контекст БД.</param>
    public CalculatingMeteringDeviceRepository(ApplicationContext applicationContext)
        : base(applicationContext)
    {
    }
}