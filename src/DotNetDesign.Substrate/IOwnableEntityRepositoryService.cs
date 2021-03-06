﻿using System;
using System.Collections.Generic;

namespace DotNetDesign.Substrate
{
    /// <summary>
    /// Defines methods for ownable entity repository services.
    /// </summary>
    /// <typeparam name="TOwnableEntityData">The type of the ownable entity data.</typeparam>
    /// <typeparam name="TOwnableEntity">The type of the ownable entity.</typeparam>
    /// <typeparam name="TOwnableEntityRepository">The type of the ownable entity repository.</typeparam>
    /// <typeparam name="TEntityDataImplementation">The type of the entity data implementation.</typeparam>
    /// <typeparam name="TOwner">The type of the owner.</typeparam>
    /// <typeparam name="TOwnerData">The type of the owner data.</typeparam>
    /// <typeparam name="TOwnerRepository">The type of the owner repository.</typeparam>
    public interface IOwnableEntityRepositoryService<TOwnableEntityData, TOwnableEntity, TOwnableEntityRepository, TEntityDataImplementation, TOwner, TOwnerData, TOwnerRepository> :
        IEntityRepositoryService<TOwnableEntityData, TOwnableEntity, TOwnableEntityRepository, TEntityDataImplementation>,
        IOwnableEntityRepositoryService<TOwnableEntityData, TOwnableEntity, TOwnableEntityRepository, Guid, TEntityDataImplementation, TOwner, TOwnerData, TOwnerRepository>
        where TOwnableEntityData : class, IOwnableEntityData<TOwnableEntityData, TOwnableEntity, TOwnableEntityRepository, TOwner, TOwnerData, TOwnerRepository>
        where TOwnableEntity : class, IOwnableEntity<TOwnableEntity, TOwnableEntityData, TOwner, TOwnableEntityRepository, TOwnerData, TOwnerRepository>, TOwnableEntityData
        where TOwnableEntityRepository : class, IOwnableEntityRepository<TOwnableEntityRepository, TOwnableEntity, TOwnableEntityData, TOwner, TOwnerData, TOwnerRepository>
        where TEntityDataImplementation : class, TOwnableEntityData
        where TOwnerData : class,IEntityData<TOwnerData, TOwner, TOwnerRepository>
        where TOwner : class, IEntity<TOwner, TOwnerData, TOwnerRepository>, TOwnerData
        where TOwnerRepository : class, IEntityRepository<TOwnerRepository, TOwner, TOwnerData>
    { }

    /// <summary>
    /// Defines methods for ownable entity repository services.
    /// </summary>
    /// <typeparam name="TOwnableEntityData">The type of the ownable entity data.</typeparam>
    /// <typeparam name="TOwnableEntity">The type of the ownable entity.</typeparam>
    /// <typeparam name="TOwnableEntityRepository">The type of the ownable entity repository.</typeparam>
    /// <typeparam name="TId">The type of the id.</typeparam>
    /// <typeparam name="TEntityDataImplementation">The type of the entity data implementation.</typeparam>
    /// <typeparam name="TOwner">The type of the owner.</typeparam>
    /// <typeparam name="TOwnerData">The type of the owner data.</typeparam>
    /// <typeparam name="TOwnerRepository">The type of the owner repository.</typeparam>
    public interface IOwnableEntityRepositoryService<TOwnableEntityData, TOwnableEntity, TOwnableEntityRepository, in TId, TEntityDataImplementation, TOwner, TOwnerData, TOwnerRepository> :
        IEntityRepositoryService<TOwnableEntityData, TOwnableEntity, TOwnableEntityRepository, TId, TEntityDataImplementation>
        where TOwnableEntityData : class, IOwnableEntityData<TOwnableEntityData, TOwnableEntity, TId, TOwnableEntityRepository, TOwner, TOwnerData, TOwnerRepository>
        where TOwnableEntity : class, IOwnableEntity<TOwnableEntity, TId, TOwnableEntityData, TOwner, TOwnableEntityRepository, TOwnerData, TOwnerRepository>, TOwnableEntityData
        where TOwnableEntityRepository : class, IOwnableEntityRepository<TOwnableEntityRepository, TOwnableEntity, TId, TOwnableEntityData, TOwner, TOwnerData, TOwnerRepository>
        where TEntityDataImplementation : class, TOwnableEntityData
        where TOwnerData : class,IEntityData<TOwnerData, TOwner, TId, TOwnerRepository>
        where TOwner : class, IEntity<TOwner, TId, TOwnerData, TOwnerRepository>, TOwnerData
        where TOwnerRepository : class, IEntityRepository<TOwnerRepository, TOwner, TId, TOwnerData>
    {
        /// <summary>
        /// Gets the ownable entites by their owner.
        /// </summary>
        /// <param name="ownerId">The owner id.</param>
        /// <param name="scopeContext">The scope context.</param>
        /// <returns></returns>
        IEnumerable<TEntityDataImplementation> GetByOwner(TId ownerId, Dictionary<string, string> scopeContext);
    }
}