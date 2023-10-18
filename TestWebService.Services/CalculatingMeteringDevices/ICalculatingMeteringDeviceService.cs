namespace TestWebService.Services.CalculatingMeteringDevices;

using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Model.CalculatingMeteringDevices;

/// <summary>
/// Интерфейс сервиса расчетных приборов учета.
/// </summary>
public interface ICalculatingMeteringDeviceService
{
    /// <summary>
    /// Получает расчетные приборы учета за требуемый год.
    /// </summary>
    /// <param name="year">Требуемый год.</param>
    /// <param name="cancellationToken">Флаг остановки выполнения операции.</param>
    /// <returns>Задача получения расчетных приборов учета за год.</returns>
    Task<List<CalculatingMeteringDevice>> GetCalculatingMeteringDevicesBy(
        int year,
        CancellationToken cancellationToken);
}