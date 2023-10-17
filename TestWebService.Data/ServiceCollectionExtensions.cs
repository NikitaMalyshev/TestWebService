namespace TestWebService.Data;

using DbInitialize;
using ElectricalDevices.EnergyMeters;
using ElectricalDevices.Transformers;
using ElectricityConsumptionObjects;
using ElectricityMeasuringPoints;
using ElectricitySupplyPoints;
using Microsoft.Extensions.DependencyInjection;
using Organizations;

/// <summary>
/// Методы расширения <see cref="IServiceCollection" />.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрирует в <see cref="IServiceCollection" /> модуль инициализации БД.
    /// </summary>
    /// <param name="services">Реестр модулей приложения.</param>
    /// <returns>Реестр модулей приложения с зарегистрированными модулем инициализации БД.</returns>
    public static IServiceCollection AddDbInitializer(this IServiceCollection services)
    {
        return services.AddTransient<IDbInitializer, DbInitializer>();
    }

    /// <summary>
    /// Регистрирует в <see cref="IServiceCollection" /> репозитории.
    /// </summary>
    /// <param name="services">Реестр модулей приложения.</param>
    /// <returns>Реестр модулей приложения с зарегистрированными репозиториями.</returns>
    public static IServiceCollection AddRepositories(this IServiceCollection services)
    {
        return services
            .AddTransient<IEnergyMeterRepository, EnergyMeterRepository>()
            .AddTransient<ITransformerRepository, TransformerRepository>()
            .AddTransient<IElectricityConsumptionObjectRepository, ElectricityConsumptionObjectRepository>()
            .AddTransient<IElectricityMeasuringPointRepository, ElectricityMeasuringPointRepository>()
            .AddTransient<IElectricitySupplyPointRepository, ElectricitySupplyPointRepository>()
            .AddTransient<IOrganizationRepository, OrganizationRepository>();
    }
}