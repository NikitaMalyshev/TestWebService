﻿namespace TestWebService.Model.Organizations;

using System;
using System.Collections.Generic;
using ElectricityConsumptionObjects;
using JetBrains.Annotations;

/// <summary>
/// Модель организации.
/// </summary>
[UsedImplicitly]
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
    public virtual Organization Parent { get; set; }

    /// <summary>
    /// Получает или задает дочерние организации.
    /// </summary>
    public virtual ICollection<Organization> ChildOrganizations { get; set; }

    /// <summary>
    /// Получает или задает объекты потребления электроэнергии.
    /// </summary>
    public virtual ICollection<ElectricityConsumptionObject> ElectricityConsumptionObjects { get; set; }
}