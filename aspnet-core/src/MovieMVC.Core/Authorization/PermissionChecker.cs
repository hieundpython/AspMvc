using Abp.Authorization;
using MovieMVC.Authorization.Roles;
using MovieMVC.Authorization.Users;

namespace MovieMVC.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
