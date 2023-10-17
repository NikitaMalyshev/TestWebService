namespace TestWebService.Data.ElectricityMeasuringPoints;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Model.ElectricalDevices.EnergyMeters;
using Model.ElectricalDevices.Transformers;
using Model.ElectricityMeasuringPoints;
using Repository;

/// <summary>
/// Интерфейс репозитория точек измерения электроэнергии.
/// </summary>
public interface IElectricityMeasuringPointRepository : IRepositoryBase<ElectricityMeasuringPoint>
{
    /// <summary>
    /// По объекту потребления получает счетчики электроэнергии с закончившимся сроком поверки.
    /// </summary>
    /// <param name="electricityConsumptionObjectId">Идентификатор объекта потребления.</param>
    /// <param name="cancellationToken">Флаг отмены выполнения операции.</param>
    /// <returns>Задача на получение счетчиков электроэнергии.</returns>
    Task<List<EnergyMeter>> GetExpiredVerificationMeters(
        Guid electricityConsumptionObjectId,
        CancellationToken cancellationToken);

    /// <summary>
    /// По объекту потребления получает трансформаторы напряжения с закончившимся сроком поверки.
    /// </summary>
    /// <param name="electricityConsumptionObjectId">Идентификатор объекта потребления.</param>
    /// <param name="transformerType">Тип трансформатора.</param>
    /// <param name="cancellationToken">Флаг отмены выполнения операции.</param>
    /// <returns>Задача на получение трансформаторов напряжения.</returns>
    Task<List<Transformer>> GetExpiredVerificationTransformers(
        Guid electricityConsumptionObjectId,
        TransformerType transformerType,
        CancellationToken cancellationToken);
}