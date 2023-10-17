namespace TestWebService.WebApi;

using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

/// <summary>
/// Главный класс приложения.
/// </summary>
public static class Program
{
    /// <summary>
    /// Точка входа.
    /// </summary>
    /// <param name="args">Параметры.</param>
    public static void Main(string[] args)
    {
        CreateHostBuilder(args).Build().Run();
    }

    /// <summary>
    /// Создает экземпляр <see cref="IWebHostBuilder"/>.
    /// </summary>
    /// <param name="args">Параметры.</param>
    /// <returns>Экземпляр <see cref="IWebHostBuilder"/>.</returns>
    private static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host
            .CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder => webBuilder.UseStartup<Startup>());
    }
}