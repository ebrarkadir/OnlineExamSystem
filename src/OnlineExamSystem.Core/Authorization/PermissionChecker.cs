using Abp.Authorization;
using OnlineExamSystem.Authorization.Roles;
using OnlineExamSystem.Authorization.Users;

namespace OnlineExamSystem.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
