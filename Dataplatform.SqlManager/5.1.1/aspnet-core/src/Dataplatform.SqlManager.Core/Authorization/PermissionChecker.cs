using Abp.Authorization;
using Dataplatform.SqlManager.Authorization.Roles;
using Dataplatform.SqlManager.Authorization.Users;

namespace Dataplatform.SqlManager.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
