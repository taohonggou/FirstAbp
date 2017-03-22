using FirstABP.EntityFramework;
using EntityFramework.DynamicFilters;

namespace FirstABP.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly FirstABPDbContext _context;

        public InitialHostDbBuilder(FirstABPDbContext context)
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
