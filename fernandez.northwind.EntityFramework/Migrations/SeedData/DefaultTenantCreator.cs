using System.Linq;
using fernandez.northwind.EntityFramework;
using fernandez.northwind.MultiTenancy;

namespace fernandez.northwind.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly northwindDbContext _context;

        public DefaultTenantCreator(northwindDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
