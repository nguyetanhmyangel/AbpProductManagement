using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AbpProductManagement.Web;

[Dependency(ReplaceServices = true)]
public class AbpProductManagementBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "AbpProductManagement";
}
