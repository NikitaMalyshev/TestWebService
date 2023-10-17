namespace TestWebService.Data.Repository;

using System;
using System.Linq;
using System.Linq.Expressions;

/// <summary>
/// Интерфейс базового репозитория.
/// </summary>
/// <typeparam name="T">Тип сущности.</typeparam>
public interface IRepositoryBase<T>
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
    void Create(T entity);

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
}