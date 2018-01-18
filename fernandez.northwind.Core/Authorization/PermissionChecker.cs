using Abp.Authorization;
using fernandez.northwind.Authorization.Roles;
using fernandez.northwind.Authorization.Users;

namespace fernandez.northwind.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
