using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace fernandez.northwind.EntityFramework.Repositories
{
    public abstract class northwindRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<northwindDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected northwindRepositoryBase(IDbContextProvider<northwindDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class northwindRepositoryBase<TEntity> : northwindRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected northwindRepositoryBase(IDbContextProvider<northwindDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
