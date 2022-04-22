using AbpProductManagement.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AbpProductManagement.Web.Pages;

/* Inherit your PageModel classes from this class.
 */
public abstract class AbpProductManagementPageModel : AbpPageModel
{
    protected AbpProductManagementPageModel()
    {
        LocalizationResourceType = typeof(AbpProductManagementResource);
    }
}
