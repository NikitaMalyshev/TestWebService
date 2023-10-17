namespace TestWebService.Services.ElectricityMeasuringPoints;

using System;
using System.Collections.Generic;
using System.Threading;
using TestWebService.Services.DTO.ElectricityMeasuringPoints;
using System.Threading.Tasks;
using Model.ElectricalDevices.EnergyMeters;

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

    /// <summary>
    /// По объекту потребления получает счетчики электроэнергии с закончившимся сроком поверки.
    /// </summary>
    /// <param name="electricityConsumptionObjectId">Идентификатор объекта потребления.</param>
    /// <param name="cancellationToken">Флаг отмены выполнения операции.</param>
    /// <returns>Задача на получение счетчиков электроэнергии.</returns>
    Task<List<EnergyMeter>> GetMetersWithExpiredVerificationDate(
        Guid electricityConsumptionObjectId,
        CancellationToken cancellationToken);
}