namespace TestWebService.Data.ElectricityMeasuringPoints;

using TestWebService.Model.ElectricityMeasuringPoints;
using TestWebService.Data.Repository;

/// <summary>
/// Интерфейс репозитория точек измерения электроэнергии.
/// </summary>
public interface IElectricityMeasuringPointRepository : IRepositoryBase<ElectricityMeasuringPoint>
{
}