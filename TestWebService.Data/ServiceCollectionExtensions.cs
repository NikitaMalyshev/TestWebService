namespace TestWebService.Data;

using TestWebService.Data.DbInitialize;
using TestWebService.Data.ElectricalDevices.EnergyMeters;
using TestWebService.Data.ElectricalDevices.Transformers;
using TestWebService.Data.ElectricityConsumptionObjects;
using TestWebService.Data.ElectricityMeasuringPoints;
using TestWebService.Data.ElectricitySupplyPoints;
using TestWebService.Data.Organizations;

using Microsoft.Extensions.DependencyInjection;

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