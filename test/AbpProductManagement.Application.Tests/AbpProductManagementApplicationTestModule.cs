using Volo.Abp.Modularity;

namespace AbpProductManagement;

[DependsOn(
    typeof(AbpProductManagementApplicationModule),
    typeof(AbpProductManagementDomainTestModule)
    )]
public class AbpProductManagementApplicationTestModule : AbpModule
{

}
