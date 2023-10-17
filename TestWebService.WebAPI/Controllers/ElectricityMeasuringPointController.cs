namespace TestWebService.WebAPI.Controllers;

using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Services.DTO.ElectricityMeasuringPoints;
using Services.ElectricityMeasuringPoints;

/// <summary>
/// Контроллер, предоставляющий функционал управления данными о точках измерения электроэнергии.
/// </summary>
[ApiController]
[Route("api/v1/[controller]/[action]")]
public class ElectricityMeasuringPointController : ControllerBase
{
    /// <summary>
    /// Сервис точек измерения электроэнергии.
    /// </summary>
    private readonly IElectricityMeasuringPointService _electricityMeasuringPointService;

    /// <summary>
    /// Инициализирует экземпляр <see cref="ElectricityMeasuringPointController" />.
    /// </summary>
    /// <param name="electricityMeasuringPointService">Сервис точек измерения электроэнергии.</param>
    public ElectricityMeasuringPointController(IElectricityMeasuringPointService electricityMeasuringPointService)
    {
        _electricityMeasuringPointService = electricityMeasuringPointService;
    }

    /// <summary>
    /// Осуществляет создание точки измерения электроэнергии.
    /// </summary>
    /// <param name="dto">Параметры создания индекса.</param>
    /// <param name="cancellationToken">Флаг остановки выполнения запроса.</param>
    /// <returns>Результат операции создания индекса.</returns>
    [HttpPost]
    public async Task<IActionResult> Create(
        CreatePointDto dto,
        CancellationToken cancellationToken)
    {
        await _electricityMeasuringPointService
            .CreatePoint(dto, cancellationToken)
            .ConfigureAwait(false);

        return Ok();
    }
}