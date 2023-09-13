using System.Collections.Generic;
using OnlineExamSystem.Roles.Dto;

namespace OnlineExamSystem.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
