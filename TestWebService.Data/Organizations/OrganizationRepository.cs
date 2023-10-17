namespace TestWebService.Data.Organizations;

using Context;
using Model.Organizations;
using Repository;

/// <summary>
/// Репозиторий точек поставки электроэнергии.
/// </summary>
public class OrganizationRepository : RepositoryBase<Organization>, IOrganizationRepository
{
    /// <summary>
    /// Инициализирует экземпляр <see cref="OrganizationRepository" />.
    /// </summary>
    /// <param name="applicationContext">Контекст БД.</param>
    public OrganizationRepository(ApplicationContext applicationContext) : base(applicationContext)
    {
    }
}