using Abp.Authorization;
using FirstABP.Authorization.Roles;
using FirstABP.MultiTenancy;
using FirstABP.Users;

namespace FirstABP.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
