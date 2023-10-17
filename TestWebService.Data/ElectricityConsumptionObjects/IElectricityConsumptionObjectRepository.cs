namespace TestWebService.Data.ElectricityConsumptionObjects;

using TestWebService.Model.ElectricityConsumptionObjects;
using TestWebService.Data.Repository;

/// <summary>
/// Интерфейс репозитория объектов потребления электроэнергии.
/// </summary>
public interface IElectricityConsumptionObjectRepository : IRepositoryBase<ElectricityConsumptionObject>
{
}