using System;

namespace DotNetDesign.EntityFramework
{
    ///<summary>
    /// Basic implementation of IPermissionAuthorizationManager that always returns true for IsAuthorized.
    ///</summary>
    public class AnonymousPermissionAuthorizationManager<TEntity, TEntityData, TEntityRepository> :
        AnonymousPermissionAuthorizationManager<TEntity, TEntityData, Guid, TEntityRepository>, IPermissionAuthorizationManager<TEntity, TEntityData, TEntityRepository>
        where TEntity : class, IEntity<TEntity, TEntityData, TEntityRepository>, TEntityData
        where TEntityData : class, IEntityData<TEntityData, TEntity, TEntityRepository>
        where TEntityRepository : class, IEntityRepository<TEntityRepository, TEntity, TEntityData>
    {
    }

    ///<summary>
    /// Basic implementation of IPermissionAuthorizationManager that always returns true for IsAuthorized.
    ///</summary>
    public class AnonymousPermissionAuthorizationManager<TEntity, TEntityData, TId, TEntityRepository> : 
        BaseLogger<AnonymousPermissionAuthorizationManager<TEntity, TEntityData, TId, TEntityRepository>>, IPermissionAuthorizationManager<TEntity, TEntityData, TId, TEntityRepository>
        where TEntity : class, IEntity<TEntity, TId, TEntityData, TEntityRepository>, TEntityData
        where TEntityData : class, IEntityData<TEntityData, TEntity, TId, TEntityRepository>
        where TEntityRepository : class, IEntityRepository<TEntityRepository, TEntity, TId, TEntityData>
    {
        /// <summary>
        /// Determines whether the authenticated user is authorized with the specified required permissions.
        /// </summary>
        /// <param name="requiredPermissions">The required permissions.</param>
        /// <returns>
        ///   <c>true</c> if the authenticated user is authorized with the specified required permissions; otherwise, <c>false</c>.
        /// </returns>
        public bool IsAuthorized(EntityPermissions requiredPermissions)
        {
            using (Logger.Scope())
            {
                Logger.InfoFormat("Returning true for IsAuthrozied call for required permissions {0}", requiredPermissions);
                return true;
            }
        }
    }
}