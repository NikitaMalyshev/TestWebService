namespace TestWebService.Data.ElectricityMeasuringPoints;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Context;
using Microsoft.EntityFrameworkCore;
using Model.ElectricalDevices.EnergyMeters;
using Model.ElectricityMeasuringPoints;
using Repository;

/// <summary>
/// Репозиторий точек измерения электроэнергии.
/// </summary>
public class ElectricityMeasuringPointRepository :
    RepositoryBase<ElectricityMeasuringPoint>,
    IElectricityMeasuringPointRepository
{
    /// <summary>
    /// Инициализирует экземпляр <see cref="ElectricityMeasuringPointRepository" />.
    /// </summary>
    /// <param name="applicationContext">Контекст БД.</param>
    public ElectricityMeasuringPointRepository(ApplicationContext applicationContext)
        : base(applicationContext)
    {
    }

    /// <inheritdoc />
    public Task<List<EnergyMeter>> GetExpiredVerificationMeters(
        Guid electricityConsumptionObjectId,
        CancellationToken cancellationToken)
    {
        return CurrentContext
            .AsNoTracking()
            .Include(p => p.EnergyMeter)
            .Where(p => p.ElectricityConsumptionObjectId == electricityConsumptionObjectId)
            .Where(p => p.EnergyMeter.VerificationDate > DateTime.Now)
            .Select(p => p.EnergyMeter)
            .ToListAsync(cancellationToken);
    }
}