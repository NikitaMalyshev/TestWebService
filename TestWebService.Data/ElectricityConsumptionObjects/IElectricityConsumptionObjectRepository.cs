namespace TestWebService.Data.ElectricityConsumptionObjects;

using Model.ElectricityConsumptionObjects;
using Repository;

/// <summary>
/// Интерфейс репозитория объектов потребления электроэнергии.
/// </summary>
public interface IElectricityConsumptionObjectRepository : IRepositoryBase<ElectricityConsumptionObject>
{
}