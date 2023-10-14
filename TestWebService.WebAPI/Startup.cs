namespace TestWebService.WebApi
{
    using System.Text.Json;
    using System.Text.Json.Serialization;
    using JetBrains.Annotations;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using TestWebService.Data.Context;

    /// <summary>
    /// Класс загрузки приложения.
    /// </summary>
    public class Startup
    {
        /// <summary>
        /// Инициализирует экземпляр <see cref="Startup"/>.
        /// </summary>
        /// <param name="configuration">Конфигурация приложения.</param>
        public Startup(IConfiguration configuration) => Configuration = configuration;

        /// <summary>
        /// Получает конфигурацию приложения.
        /// </summary>
        private IConfiguration Configuration { get; }

        /// <summary>
        /// Выполняет внедрение и настройку сервисов.
        /// </summary>
        /// <param name="services">Коллекция сервисов.</param>
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddControllers()
                .AddJsonOptions(o => o.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.CamelCase)));
            services.AddEndpointsApiExplorer();
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddSwaggerGen();
        }

        /// <summary>
        /// Выполняет настройку приложения.
        /// </summary>
        /// <param name="applicationBuilder">Компонент для настройки приложения.</param>
        [UsedImplicitly]
        public void Configure(IApplicationBuilder applicationBuilder)
        {
            applicationBuilder.UseSwagger();
            applicationBuilder.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "TestWebService V1");
            });

            applicationBuilder
                .UseRouting()
                .UseAuthorization()
                .UseEndpoints(endpoints => endpoints.MapControllers());
        }
    }
}