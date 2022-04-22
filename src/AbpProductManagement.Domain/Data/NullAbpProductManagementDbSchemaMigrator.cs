using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpProductManagement.Data;

/* This is used if database provider does't define
 * IAbpProductManagementDbSchemaMigrator implementation.
 */
public class NullAbpProductManagementDbSchemaMigrator : IAbpProductManagementDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
