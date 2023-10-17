namespace TestWebService.Data.ElectricityMeasuringPoints;

using TestWebService.Data.Context;
using TestWebService.Model.ElectricityMeasuringPoints;
using TestWebService.Data.Repository;

/// <summary>
/// Репозиторий точек измерения электроэнергии.
/// </summary>
public class ElectricityMeasuringPointRepository :
    RepositoryBase<ElectricityMeasuringPoint>,
    IElectricityMeasuringPointRepository
{
    /// <summary>
    /// Инициализирует экземпляр <see cref="ElectricityMeasuringPointRepository" />.
    /// </summary>
    /// <param name="applicationContext">Контекст БД.</param>
    public ElectricityMeasuringPointRepository(ApplicationContext applicationContext)
        : base(applicationContext)
    {
    }
}