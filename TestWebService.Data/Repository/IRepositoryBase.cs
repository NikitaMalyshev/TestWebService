namespace TestWebService.Data.Repository;

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Threading;

/// <summary>
/// Интерфейс базового репозитория.
/// </summary>
/// <typeparam name="T">Тип сущности.</typeparam>
public interface IRepositoryBase<T> where T : class
{
    /// <summary>
    /// Поиск всех сущностей.
    /// </summary>
    /// <returns>Коллекция найденных сущностей.</returns>
    IQueryable<T> FindAll();

    /// <summary>
    /// Поиск сущностей по переданному условию.
    /// </summary>
    /// <param name="expression">Условие поиска.</param>
    /// <returns>Коллекция найденных сущностей.</returns>
    IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression);

    /// <summary>
    /// Создание сущности.
    /// </summary>
    /// <param name="entity">Сущность.</param>
    /// <param name="token">Флаг отмены выполнения операции.</param>
    /// <returns>Результат выполнения задачи.</returns>
    ValueTask<EntityEntry<T>> CreateAsync(T entity, CancellationToken token);

    /// <summary>
    /// Обновление сущности.
    /// </summary>
    /// <param name="entity">Сущность.</param>
    void Update(T entity);

    /// <summary>
    /// Удаление сущности.
    /// </summary>
    /// <param name="entity">Сущность.</param>
    void Delete(T entity);

    /// <summary>
    /// Сохраняет изменения в контексте.
    /// </summary>
    /// <returns>Задача сохранения изменений в контексте.</returns>
    Task<int> SaveAsync();
}