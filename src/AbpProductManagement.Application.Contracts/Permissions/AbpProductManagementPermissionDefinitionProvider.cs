using AbpProductManagement.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpProductManagement.Permissions;

public class AbpProductManagementPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpProductManagementPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpProductManagementPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpProductManagementResource>(name);
    }
}
