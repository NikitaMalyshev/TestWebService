namespace TestWebService.Data.Repository;

using System;
using System.Linq;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using TestWebService.Data.Context;

/// <summary>
/// Базовый репозиторий.
/// </summary>
/// <typeparam name="T">Тип сущности.</typeparam>
public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    /// <summary>
    /// Контекст БД.
    /// </summary>
    protected readonly ApplicationContext DbContext;

    /// <summary>
    /// Инициализирует экземпляр <see cref="RepositoryBase{T}" />.
    /// </summary>
    /// <param name="dbContext">Контекст БД.</param>
    protected RepositoryBase(ApplicationContext dbContext)
    {
        DbContext = dbContext;
    }

    /// <inheritdoc />
    public IQueryable<T> FindAll()
    {
        return DbContext.Set<T>().AsNoTracking();
    }

    /// <inheritdoc />
    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
    {
        return DbContext.Set<T>().Where(expression).AsNoTracking();
    }

    /// <inheritdoc />
    public void Create(T entity)
    {
        DbContext.Set<T>().Add(entity);
    }

    /// <inheritdoc />
    public void Update(T entity)
    {
        DbContext.Set<T>().Update(entity);
    }

    /// <inheritdoc />
    public void Delete(T entity)
    {
        DbContext.Set<T>().Remove(entity);
    }
}