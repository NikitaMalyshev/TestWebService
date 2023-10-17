namespace TestWebService.Data.ElectricitySupplyPoints;

using TestWebService.Data.Context;
using TestWebService.Model.ElectricitySupplyPoints;
using TestWebService.Data.Repository;

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