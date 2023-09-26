using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace OnlineExamSystem.Authorization
{
    public class OnlineExamSystemAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            context.CreatePermission(PermissionNames.Pages_Users, L("Users"));
            context.CreatePermission(PermissionNames.Pages_Users_Activation, L("UsersActivation"));
            context.CreatePermission(PermissionNames.Pages_Roles, L("Roles"));
            context.CreatePermission(PermissionNames.Pages_Tenants, L("Tenants"), multiTenancySides: MultiTenancySides.Host);
            context.CreatePermission(PermissionNames.Pages_Teacher, L("Teachers"));
            context.CreatePermission(PermissionNames.Pages_Teacher_Create, L("TeacherCreate"));
            context.CreatePermission(PermissionNames.Pages_Exams, L("Exams"));
            context.CreatePermission(PermissionNames.Pages_Exams_Create, L("ExamsCreate"));
            context.CreatePermission(PermissionNames.Pages_Exams_Update, L("ExamsUpdate"));
            context.CreatePermission(PermissionNames.Pages_Exams_Delete, L("ExamDelete"));
            context.CreatePermission(PermissionNames.Pages_Departments, L("Departmenst"));
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, OnlineExamSystemConsts.LocalizationSourceName);
        }
    }
}
