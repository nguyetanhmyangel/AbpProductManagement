using Volo.Abp.Settings;

namespace AbpProductManagement.Settings;

public class AbpProductManagementSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpProductManagementSettings.MySetting1));
    }
}
