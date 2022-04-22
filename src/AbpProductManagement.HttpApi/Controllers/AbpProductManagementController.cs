using AbpProductManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpProductManagement.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpProductManagementController : AbpControllerBase
{
    protected AbpProductManagementController()
    {
        LocalizationResource = typeof(AbpProductManagementResource);
    }
}
