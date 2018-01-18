using fernandez.northwind.EntityFramework;
using EntityFramework.DynamicFilters;

namespace fernandez.northwind.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly northwindDbContext _context;

        public InitialHostDbBuilder(northwindDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
