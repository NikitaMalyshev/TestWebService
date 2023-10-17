namespace TestWebService.Services.ElectricityMeasuringPoints;

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Data.ElectricityMeasuringPoints;
using DTO.ElectricityMeasuringPoints;
using Model.ElectricalDevices.EnergyMeters;
using Model.ElectricalDevices.Transformers;
using Model.ElectricityMeasuringPoints;

/// <summary>
/// Сервис точек измерения электроэнергии.
/// </summary>
public class ElectricityMeasuringPointService : IElectricityMeasuringPointService
{
    /// <summary>
    /// Репозиторий точек измерения электроэнергии.
    /// </summary>
    private readonly IElectricityMeasuringPointRepository _repository;

    /// <summary>
    /// Инициализирует экземпляр <see cref="ElectricityMeasuringPointService" />.
    /// </summary>
    /// <param name="repository">Репозиторий точек измерения электроэнергии.</param>
    public ElectricityMeasuringPointService(IElectricityMeasuringPointRepository repository)
    {
        _repository = repository;
    }

    /// <inheritdoc />
    public async Task CreatePoint(
        CreatePointDto dto,
        CancellationToken cancellationToken)
    {
        if (dto == null)
            throw new ArgumentNullException(nameof(dto));

        var newPoint = new ElectricityMeasuringPoint
        {
            Id = Guid.NewGuid(),
            Name = dto.Name,
            EnergyMeter = new EnergyMeter
            {
                Id = Guid.NewGuid(),
                Number = dto.EnergyMeter.Number,
                Type = dto.EnergyMeter.Type,
                VerificationDate = dto.EnergyMeter.VerificationDate
            },
            CurrentTransformer = new Transformer
            {
                Id = Guid.NewGuid(),
                Number = dto.CurrentTransformer.Number,
                Type = TransformerType.Current,
                Subtype = dto.CurrentTransformer.Subtype,
                VerificationDate = dto.CurrentTransformer.VerificationDate,
                TransformationRatio = dto.CurrentTransformer.TransformationRatio
            },
            VoltageTransformer = new Transformer
            {
                Id = Guid.NewGuid(),
                Number = dto.VoltageTransformer.Number,
                Type = TransformerType.Voltage,
                Subtype = dto.VoltageTransformer.Subtype,
                VerificationDate = dto.VoltageTransformer.VerificationDate,
                TransformationRatio = dto.VoltageTransformer.TransformationRatio
            },
            ElectricityConsumptionObjectId = dto.ElectricityConsumptionObjectId
        };

        await _repository.CreateAsync(newPoint, cancellationToken).ConfigureAwait(false);
        await _repository.SaveAsync();
    }

    /// <inheritdoc />
    public Task<List<EnergyMeter>> GetMetersWithExpiredVerificationDate(
        Guid electricityConsumptionObjectId,
        CancellationToken cancellationToken)
    {
        return _repository.GetExpiredVerificationMeters(electricityConsumptionObjectId, cancellationToken);
    }
}