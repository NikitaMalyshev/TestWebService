namespace TestWebService.WebAPI.Controllers;

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.ElectricalDevices.EnergyMeters;
using Services.DTO.ElectricityMeasuringPoints;
using Services.ElectricityMeasuringPoints;
using Swashbuckle.AspNetCore.Annotations;

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
    [SwaggerOperation]
    public async Task<IActionResult> Create(
        CreatePointDto dto,
        CancellationToken cancellationToken)
    {
        await _electricityMeasuringPointService
            .CreatePoint(dto, cancellationToken)
            .ConfigureAwait(false);

        return Ok();
    }

    /// <summary>
    /// По объекту потребления получает список счетчиков электроэнергии с закончившимся сроком поверки.
    /// </summary>
    /// <param name="electricityConsumptionObjectId">Идентификатор объекта потребления.</param>
    /// <param name="cancellationToken">Флаг остановки выполнения запроса.</param>
    /// <returns>Сведения об индексе.</returns>
    [HttpGet]
    [SwaggerOperation]
    [ProducesResponseType(typeof(ICollection<EnergyMeter>), StatusCodes.Status200OK)]
    public async Task<IActionResult> GetExpiredVerificationEnergyMeters(
        [Required] Guid electricityConsumptionObjectId,
        CancellationToken cancellationToken)
    {
        var response = await _electricityMeasuringPointService
            .GetMetersWithExpiredVerificationDate(electricityConsumptionObjectId, cancellationToken)
            .ConfigureAwait(false);

        return Ok(response);
    }
}