using System.Threading.Tasks;

namespace AbpProductManagement.Data;

public interface IAbpProductManagementDbSchemaMigrator
{
    Task MigrateAsync();
}
