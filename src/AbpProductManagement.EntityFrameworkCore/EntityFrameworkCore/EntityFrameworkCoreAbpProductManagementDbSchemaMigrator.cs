using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpProductManagement.Data;
using Volo.Abp.DependencyInjection;

namespace AbpProductManagement.EntityFrameworkCore;

public class EntityFrameworkCoreAbpProductManagementDbSchemaMigrator
    : IAbpProductManagementDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpProductManagementDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpProductManagementDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpProductManagementDbContext>()
            .Database
            .MigrateAsync();
    }
}
