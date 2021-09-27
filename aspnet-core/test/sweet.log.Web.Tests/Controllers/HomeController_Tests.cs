using System.Threading.Tasks;
using sweet.log.Models.TokenAuth;
using sweet.log.Web.Controllers;
using Shouldly;
using Xunit;

namespace sweet.log.Web.Tests.Controllers
{
    public class HomeController_Tests: logWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}