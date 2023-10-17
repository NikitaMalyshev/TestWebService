namespace TestWebService.Data.ElectricityConsumptionObjects;

using Context;
using Model.ElectricityConsumptionObjects;
using Repository;

/// <summary>
/// Репозиторий объектов потребления электроэнергии.
/// </summary>
public class ElectricityConsumptionObjectRepository :
    RepositoryBase<ElectricityConsumptionObject>,
    IElectricityConsumptionObjectRepository
{
    /// <summary>
    /// Инициализирует экземпляр <see cref="ElectricityConsumptionObjectRepository" />.
    /// </summary>
    /// <param name="applicationContext">Контекст БД.</param>
    public ElectricityConsumptionObjectRepository(ApplicationContext applicationContext)
        : base(applicationContext)
    {
    }
}