using System;
using System.Collections.Generic;
using System.Text;
using AbpProductManagement.Localization;
using Volo.Abp.Application.Services;

namespace AbpProductManagement;

/* Inherit your application services from this class.
 */
public abstract class AbpProductManagementAppService : ApplicationService
{
    protected AbpProductManagementAppService()
    {
        LocalizationResource = typeof(AbpProductManagementResource);
    }
}
