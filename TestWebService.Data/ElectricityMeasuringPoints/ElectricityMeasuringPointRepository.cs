namespace TestWebService.Data.ElectricityMeasuringPoints;

using Context;
using Model.ElectricityMeasuringPoints;
using Repository;

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