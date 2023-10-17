namespace TestWebService.Data.ElectricitySupplyPoints;

using TestWebService.Model.ElectricitySupplyPoints;
using TestWebService.Data.Repository;

/// <summary>
/// Интерфейс репозитория точек поставки электроэнергии.
/// </summary>
public interface IElectricitySupplyPointRepository : IRepositoryBase<ElectricitySupplyPoint>
{
}