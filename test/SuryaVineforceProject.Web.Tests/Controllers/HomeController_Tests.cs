using System.Threading.Tasks;
using SuryaVineforceProject.Models.TokenAuth;
using SuryaVineforceProject.Web.Controllers;
using Shouldly;
using Xunit;

namespace SuryaVineforceProject.Web.Tests.Controllers
{
    public class HomeController_Tests: SuryaVineforceProjectWebTestBase
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