namespace TestWebService.Data.DbInitialize;

using DTO;

/// <summary>
/// Интерфейс инициализатора БД.
/// </summary>
public interface IDbInitializer
{
    /// <summary>
    /// Генерирует начальные тестовые данные для инициализации БД.
    /// </summary>
    /// <returns>Граф объектов для инициализации БД.</returns>
    TestDataGraph GenerateTestData();
}