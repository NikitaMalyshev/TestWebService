namespace TestWebService.Services;

using ElectricityMeasuringPoints;
using Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Методы расширения <see cref="IServiceCollection" />.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрирует в <see cref="IServiceCollection" /> сервисы.
    /// </summary>
    /// <param name="services">Реестр модулей приложения.</param>
    /// <returns>Реестр модулей приложения с зарегистрированными сервисами.</returns>
    public static IServiceCollection AddServices(this IServiceCollection services)
    {
        return services.AddTransient<IElectricityMeasuringPointService, ElectricityMeasuringPointService>();
    }
}