using System.Data.Entity.Migrations;
using Abp.MultiTenancy;
using Abp.Zero.EntityFramework;
using fernandez.northwind.Migrations.SeedData;
using EntityFramework.DynamicFilters;

namespace fernandez.northwind.Migrations
{
    public sealed class Configuration : DbMigrationsConfiguration<northwind.EntityFramework.northwindDbContext>, IMultiTenantSeed
    {
        public AbpTenantBase Tenant { get; set; }

        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "northwind";
        }

        protected override void Seed(northwind.EntityFramework.northwindDbContext context)
        {
            context.DisableAllFilters();

            if (Tenant == null)
            {
                //Host seed
                new InitialHostDbBuilder(context).Create();

                //Default tenant seed (in host database).
                new DefaultTenantCreator(context).Create();
                new TenantRoleAndUserBuilder(context, 1).Create();
            }
            else
            {
                //You can add seed for tenant databases and use Tenant property...
            }

            context.SaveChanges();
        }
    }
}
