namespace TestWebService.Model.Organizations;

using System;
using System.Collections.Generic;
using TestWebService.Model.ElectricityConsumptionObjects;

/// <summary>
/// Модель организации.
/// </summary>
public class Organization
{
    /// <summary>
    /// Получает или задает идентификатор организации.
    /// </summary>
    public Guid Id { get; set; }

    /// <summary>
    /// Получает или задает наименование организации.
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Получает или задает адрес организации.
    /// </summary>
    public string Address { get; set; }

    /// <summary>
    /// Получает или задает идентификатор родительской организации.
    /// </summary>
    public Guid? ParentOrganizationId { get; set; }

    /// <summary>
    /// Получает или задает родительскую организацию.
    /// </summary>
    public virtual Organization ParentOrganization { get; set; }

    /// <summary>
    /// Получает или задает дочерние организации.
    /// </summary>
    public virtual ICollection<Organization> ChildOrganizations { get; set; }

    /// <summary>
    /// Получает или задает объекты потребления электроэнергии.
    /// </summary>
    public ICollection<ElectricityConsumptionObject> ElectricityConsumptionObjects { get; set; }
}