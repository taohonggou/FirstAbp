using System.Linq;
using FirstABP.EntityFramework;
using FirstABP.MultiTenancy;

namespace FirstABP.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly FirstABPDbContext _context;

        public DefaultTenantCreator(FirstABPDbContext context)
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
