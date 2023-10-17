namespace TestWebService.Data.ElectricityMeasuringPoints;

using Model.ElectricityMeasuringPoints;
using Repository;

/// <summary>
/// Интерфейс репозитория точек измерения электроэнергии.
/// </summary>
public interface IElectricityMeasuringPointRepository : IRepositoryBase<ElectricityMeasuringPoint>
{
}