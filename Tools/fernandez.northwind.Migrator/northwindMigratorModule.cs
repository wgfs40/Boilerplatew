using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using fernandez.northwind.EntityFramework;

namespace fernandez.northwind.Migrator
{
    [DependsOn(typeof(northwindDataModule))]
    public class northwindMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<northwindDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}