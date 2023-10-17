namespace TestWebService.Data.ElectricitySupplyPoints;

using Context;
using Model.ElectricitySupplyPoints;
using Repository;

/// <summary>
/// Репозиторий точек поставки электроэнергии.
/// </summary>
public class ElectricitySupplyPointRepository :
    RepositoryBase<ElectricitySupplyPoint>,
    IElectricitySupplyPointRepository
{
    /// <summary>
    /// Инициализирует экземпляр <see cref="ElectricitySupplyPointRepository" />.
    /// </summary>
    /// <param name="applicationContext">Контекст БД.</param>
    public ElectricitySupplyPointRepository(ApplicationContext applicationContext)
        : base(applicationContext)
    {
    }
}