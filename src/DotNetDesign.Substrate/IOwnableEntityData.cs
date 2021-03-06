﻿using System;

namespace DotNetDesign.Substrate
{
    /// <summary>
    /// Represents an ownable entity data.
    /// </summary>
    /// <typeparam name="TOwnableEntityData">The type of the ownable entity data.</typeparam>
    /// <typeparam name="TOwnableEntity">The type of the ownable entity.</typeparam>
    /// <typeparam name="TOwnableEntityRepository">The type of the ownable entity repository.</typeparam>
    /// <typeparam name="TOwner">The type of the owner.</typeparam>
    /// <typeparam name="TOwnerData">The type of the owner data.</typeparam>
    /// <typeparam name="TOwnerRepository">The type of the owner repository.</typeparam>
    public interface IOwnableEntityData<TOwnableEntityData, out TOwnableEntity, TOwnableEntityRepository, TOwner, TOwnerData, TOwnerRepository> :
        IOwnableEntityData<TOwnableEntityData, TOwnableEntity, Guid, TOwnableEntityRepository, TOwner, TOwnerData, TOwnerRepository>,
        IEntityData<TOwnableEntityData, TOwnableEntity, TOwnableEntityRepository>
        where TOwnableEntityData : class, IOwnableEntityData<TOwnableEntityData, TOwnableEntity, TOwnableEntityRepository, TOwner, TOwnerData, TOwnerRepository>
        where TOwnableEntity : class, IOwnableEntity<TOwnableEntity, TOwnableEntityData, TOwner, TOwnableEntityRepository, TOwnerData, TOwnerRepository>, TOwnableEntityData
        where TOwnableEntityRepository : class, IOwnableEntityRepository<TOwnableEntityRepository, TOwnableEntity, TOwnableEntityData, TOwner, TOwnerData, TOwnerRepository>
        where TOwnerData : class,IEntityData<TOwnerData, TOwner, TOwnerRepository>
        where TOwner : class, IEntity<TOwner, TOwnerData, TOwnerRepository>, TOwnerData
        where TOwnerRepository : class, IEntityRepository<TOwnerRepository, TOwner, TOwnerData>
    { }

    /// <summary>
    /// Represents an ownable entity data.
    /// </summary>
    /// <typeparam name="TOwnableEntityData">The type of the ownable entity data.</typeparam>
    /// <typeparam name="TOwnableEntity">The type of the ownable entity.</typeparam>
    /// <typeparam name="TId">The type of the id.</typeparam>
    /// <typeparam name="TOwnableEntityRepository">The type of the ownable entity repository.</typeparam>
    /// <typeparam name="TOwner">The type of the owner.</typeparam>
    /// <typeparam name="TOwnerData">The type of the owner data.</typeparam>
    /// <typeparam name="TOwnerRepository">The type of the owner repository.</typeparam>
    public interface IOwnableEntityData<TOwnableEntityData, out TOwnableEntity, TId, TOwnableEntityRepository, TOwner, TOwnerData, TOwnerRepository> :
        IEntityData<TOwnableEntityData, TOwnableEntity, TId, TOwnableEntityRepository>, IOwnable
        where TOwnableEntityData : class, IOwnableEntityData<TOwnableEntityData, TOwnableEntity, TId, TOwnableEntityRepository, TOwner, TOwnerData, TOwnerRepository>
        where TOwnableEntity : class, IOwnableEntity<TOwnableEntity, TId, TOwnableEntityData, TOwner, TOwnableEntityRepository, TOwnerData, TOwnerRepository>, TOwnableEntityData
        where TOwnableEntityRepository : class, IOwnableEntityRepository<TOwnableEntityRepository, TOwnableEntity, TId, TOwnableEntityData, TOwner, TOwnerData, TOwnerRepository>
        where TOwnerData : class,IEntityData<TOwnerData, TOwner, TId, TOwnerRepository>
        where TOwner : class, IEntity<TOwner, TId, TOwnerData, TOwnerRepository>, TOwnerData
        where TOwnerRepository : class, IEntityRepository<TOwnerRepository, TOwner, TId, TOwnerData>
    {
        /// <summary>
        /// Gets or sets the owner id.
        /// </summary>
        /// <value>
        /// The owner id.
        /// </value>
        TId OwnerId { get; set; }
    }
}