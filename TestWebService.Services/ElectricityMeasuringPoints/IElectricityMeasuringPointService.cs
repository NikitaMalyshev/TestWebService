namespace TestWebService.Services.ElectricityMeasuringPoints;

using System.Threading;
using TestWebService.Services.DTO.ElectricityMeasuringPoints;
using System.Threading.Tasks;

/// <summary>
/// Интерфейс сервиса точек измерения электроэнергии.
/// </summary>
public interface IElectricityMeasuringPointService
{
    /// <summary>
    /// Создает точку измерения электроэнергии.
    /// </summary>
    /// <param name="dto">Данные для создания точки измерения.</param>
    /// <param name="cancellationToken">Флаг отмены выполнения операции.</param>
    /// <returns>Задача на создание точки измерения.</returns>
    Task CreatePoint(CreatePointDto dto, CancellationToken cancellationToken);
}