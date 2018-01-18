using System;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.IdentityFramework;
using Abp.Runtime.Session;
using fernandez.northwind.Authorization.Users;
using fernandez.northwind.MultiTenancy;
using fernandez.northwind.Users;
using Microsoft.AspNet.Identity;

namespace fernandez.northwind
{
    /// <summary>
    /// Derive your application services from this class.
    /// </summary>
    public abstract class northwindAppServiceBase : ApplicationService
    {
        public TenantManager TenantManager { get; set; }

        public UserManager UserManager { get; set; }

        protected northwindAppServiceBase()
        {
            LocalizationSourceName = northwindConsts.LocalizationSourceName;
        }

        protected virtual Task<User> GetCurrentUserAsync()
        {
            var user = UserManager.FindByIdAsync(AbpSession.GetUserId());
            if (user == null)
            {
                throw new ApplicationException("There is no current user!");
            }

            return user;
        }

        protected virtual Task<Tenant> GetCurrentTenantAsync()
        {
            return TenantManager.GetByIdAsync(AbpSession.GetTenantId());
        }

        protected virtual void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}