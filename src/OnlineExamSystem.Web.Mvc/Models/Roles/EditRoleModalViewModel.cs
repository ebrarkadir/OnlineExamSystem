using Abp.AutoMapper;
using OnlineExamSystem.Roles.Dto;
using OnlineExamSystem.Web.Models.Common;

namespace OnlineExamSystem.Web.Models.Roles
{
    [AutoMapFrom(typeof(GetRoleForEditOutput))]
    public class EditRoleModalViewModel : GetRoleForEditOutput, IPermissionsEditViewModel
    {
        public bool HasPermission(FlatPermissionDto permission)
        {
            return GrantedPermissionNames.Contains(permission.Name);
        }
    }
}
