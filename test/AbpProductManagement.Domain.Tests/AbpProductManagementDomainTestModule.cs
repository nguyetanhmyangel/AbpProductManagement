using AbpProductManagement.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpProductManagement;

[DependsOn(
    typeof(AbpProductManagementEntityFrameworkCoreTestModule)
    )]
public class AbpProductManagementDomainTestModule : AbpModule
{

}
