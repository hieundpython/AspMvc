using System.Threading.Tasks;
using MovieMVC.Models.TokenAuth;
using MovieMVC.Web.Controllers;
using Shouldly;
using Xunit;

namespace MovieMVC.Web.Tests.Controllers
{
    public class HomeController_Tests: MovieMVCWebTestBase
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