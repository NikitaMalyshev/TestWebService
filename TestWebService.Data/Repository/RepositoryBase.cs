namespace TestWebService.Data.Repository;

using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;
using Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

/// <summary>
/// Базовый репозиторий.
/// </summary>
/// <typeparam name="T">Тип сущности.</typeparam>
public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
    /// <summary>
    /// Контекст БД.
    /// </summary>
    private readonly ApplicationContext _dbContext;

    /// <summary>
    /// Инициализирует экземпляр <see cref="RepositoryBase{T}" />.
    /// </summary>
    /// <param name="dbContext">Контекст БД.</param>
    protected RepositoryBase(ApplicationContext dbContext)
    {
        _dbContext = dbContext;
    }

    /// <inheritdoc />
    public IQueryable<T> FindAll()
    {
        return _dbContext.Set<T>().AsNoTracking();
    }

    /// <inheritdoc />
    public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression)
    {
        return _dbContext.Set<T>().Where(expression).AsNoTracking();
    }

    /// <inheritdoc />
    public ValueTask<EntityEntry<T>> CreateAsync(T entity, CancellationToken token)
    {
        return _dbContext.Set<T>().AddAsync(entity, token);
    }

    /// <inheritdoc />
    public void Update(T entity)
    {
        _dbContext.Set<T>().Update(entity);
    }

    /// <inheritdoc />
    public void Delete(T entity)
    {
        _dbContext.Set<T>().Remove(entity);
    }

    /// <inheritdoc />
    public Task<int> SaveAsync()
    {
        return _dbContext.SaveChangesAsync();
    }
}