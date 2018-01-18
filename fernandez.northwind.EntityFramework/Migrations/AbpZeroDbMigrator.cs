using Abp.Dependency;
using Abp.Domain.Uow;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using fernandez.northwind.EntityFramework;

namespace fernandez.northwind.Migrations
{
    public class AbpZeroDbMigrator : AbpZeroDbMigrator<northwindDbContext, Configuration>
    {
        public AbpZeroDbMigrator(
            IUnitOfWorkManager unitOfWorkManager,
            IDbPerTenantConnectionStringResolver connectionStringResolver,
            IIocResolver iocResolver)
            : base(
                unitOfWorkManager,
                connectionStringResolver,
                iocResolver)
        {
        }
    }
}
