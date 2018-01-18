using System.Reflection;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Modules;
using Abp.Zero;
using Abp.Zero.Configuration;
using fernandez.northwind.Authorization;
using fernandez.northwind.Authorization.Roles;
using fernandez.northwind.Authorization.Users;
using fernandez.northwind.Configuration;
using fernandez.northwind.MultiTenancy;

namespace fernandez.northwind
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class northwindCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            //Remove the following line to disable multi-tenancy.
            Configuration.MultiTenancy.IsEnabled = northwindConsts.MultiTenancyEnabled;

            //Add/remove localization sources here
            Configuration.Localization.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    northwindConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        Assembly.GetExecutingAssembly(),
                        "fernandez.northwind.Localization.Source"
                        )
                    )
                );

            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Authorization.Providers.Add<northwindAuthorizationProvider>();

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
