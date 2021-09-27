using Abp.Authorization;
using sweet.log.Authorization.Roles;
using sweet.log.Authorization.Users;

namespace sweet.log.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
