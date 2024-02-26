using Abp.Authorization;
using SuryaVineforceProject.Authorization.Roles;
using SuryaVineforceProject.Authorization.Users;

namespace SuryaVineforceProject.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
