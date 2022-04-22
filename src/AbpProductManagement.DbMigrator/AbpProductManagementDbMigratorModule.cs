using AbpProductManagement.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpProductManagement.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpProductManagementEntityFrameworkCoreModule),
    typeof(AbpProductManagementApplicationContractsModule)
    )]
public class AbpProductManagementDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
