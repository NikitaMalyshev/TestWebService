namespace TestWebService.Data;

using TestWebService.Data.DbInitialize;

using Microsoft.Extensions.DependencyInjection;

/// <summary>
/// Методы расширения <see cref="IServiceCollection" />.
/// </summary>
public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Регистрирует в <see cref="IServiceCollection" /> модуль инициализации БД событий.
    /// </summary>
    /// <param name="services">Реестр модулей приложения.</param>
    /// <returns>
    /// Реестр модулей приложения с зарегистрированными модулями ведения журнала Syslog.
    /// </returns>
    public static IServiceCollection AddDbInitializer(this IServiceCollection services)
    {
        return services.AddTransient<IDbInitializer, DbInitializer>();
    }
}