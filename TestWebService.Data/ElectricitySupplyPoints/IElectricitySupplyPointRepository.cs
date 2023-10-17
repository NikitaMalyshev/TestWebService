namespace TestWebService.Data.ElectricitySupplyPoints;

using Model.ElectricitySupplyPoints;
using Repository;

/// <summary>
/// Интерфейс репозитория точек поставки электроэнергии.
/// </summary>
public interface IElectricitySupplyPointRepository : IRepositoryBase<ElectricitySupplyPoint>
{
}