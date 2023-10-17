namespace TestWebService.Data.ElectricalDevices.Transformers;

using Context;
using Model.ElectricalDevices.Transformers;
using Repository;

/// <summary>
/// Репозиторий счетчиков электроэнергии.
/// </summary>
public class TransformerRepository : RepositoryBase<Transformer>, ITransformerRepository
{
    /// <summary>
    /// Инициализирует экземпляр <see cref="TransformerRepository" />.
    /// </summary>
    /// <param name="applicationContext">Контекст БД.</param>
    public TransformerRepository(ApplicationContext applicationContext) : base(applicationContext)
    {
    }
}