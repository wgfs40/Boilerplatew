using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using fernandez.northwind.EntityFramework;

namespace fernandez.northwind
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(northwindCoreModule))]
    public class northwindDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<northwindDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
