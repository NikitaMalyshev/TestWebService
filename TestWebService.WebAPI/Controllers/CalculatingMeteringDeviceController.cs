namespace TestWebService.WebAPI.Controllers;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.CalculatingMeteringDevices;
using Services.CalculatingMeteringDevices;
using Swashbuckle.AspNetCore.Annotations;

/// <summary>
/// Контроллер, предоставляющий функционал управления данными о расчетных приборах учета.
/// </summary>
[ApiController]
[Route("api/v1/[controller]/[action]")]
public class CalculatingMeteringDeviceController : ControllerBase
{
    /// <summary>
    /// Сервис расчетных приборов учета.
    /// </summary>
    private readonly ICalculatingMeteringDeviceService _calculatingMeteringDeviceService;

    /// <summary>
    /// Инициализирует экземпляр <see cref="CalculatingMeteringDeviceController" />.
    /// </summary>
    /// <param name="calculatingMeteringDeviceService">Сервис расчетных приборов учета.</param>
    public CalculatingMeteringDeviceController(ICalculatingMeteringDeviceService calculatingMeteringDeviceService)
    {
        _calculatingMeteringDeviceService = calculatingMeteringDeviceService;
    }

    /// <summary>
    /// Получает расчетные приборы учета за переданный год.
    /// </summary>
    /// <param name="year">Требуемый год.</param>
    /// <param name="cancellationToken">Флаг остановки выполнения запроса.</param>
    /// <returns>Сведения о расчетных приборах учета.</returns>
    [HttpGet]
    [SwaggerOperation]
    [ProducesResponseType(typeof(List<CalculatingMeteringDevice>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetExpiredVerificationEnergyMeters(
        [Required] int year,
        CancellationToken cancellationToken)
    {
        var response = await _calculatingMeteringDeviceService
            .GetCalculatingMeteringDevicesBy(year, cancellationToken)
            .ConfigureAwait(false);

        return Ok(response);
    }
}