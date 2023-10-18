namespace TestWebService.Services.CalculatingMeteringDevices;

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Data.CalculatingMeteringDevices;
using Microsoft.EntityFrameworkCore;
using Model.CalculatingMeteringDevices;

/// <summary>
/// Сервис расчетных приборов учета.
/// </summary>
public class CalculatingMeteringDeviceService : ICalculatingMeteringDeviceService
{
    /// <summary>
    /// Репозиторий точек измерения электроэнергии.
    /// </summary>
    private readonly ICalculatingMeteringDeviceRepository _repository;

    /// <summary>
    /// Инициализирует экземпляр <see cref="CalculatingMeteringDeviceService" />.
    /// </summary>
    /// <param name="repository">Репозиторий точек измерения электроэнергии.</param>
    public CalculatingMeteringDeviceService(ICalculatingMeteringDeviceRepository repository)
    {
        _repository = repository;
    }

    /// <inheritdoc />
    public Task<List<CalculatingMeteringDevice>> GetCalculatingMeteringDevicesBy(
        int year,
        CancellationToken cancellationToken)
    {
        Expression<Func<CalculatingMeteringDevice, bool>> expression =
            (e) => year >= e.StartDate.Year && year <= e.EndDate.Year;

        return _repository.FindByCondition(expression).ToListAsync(cancellationToken);
    }
}