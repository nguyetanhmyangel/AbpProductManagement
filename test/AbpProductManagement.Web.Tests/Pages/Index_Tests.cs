using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace AbpProductManagement.Pages;

public class Index_Tests : AbpProductManagementWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
