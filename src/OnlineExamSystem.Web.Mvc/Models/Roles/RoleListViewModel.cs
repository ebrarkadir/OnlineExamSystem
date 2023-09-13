using System.Collections.Generic;
using OnlineExamSystem.Roles.Dto;

namespace OnlineExamSystem.Web.Models.Roles
{
    public class RoleListViewModel
    {
        public IReadOnlyList<PermissionDto> Permissions { get; set; }
    }
}
