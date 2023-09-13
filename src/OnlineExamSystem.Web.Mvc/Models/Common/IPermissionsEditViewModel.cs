using System.Collections.Generic;
using OnlineExamSystem.Roles.Dto;

namespace OnlineExamSystem.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}