using System.Threading.Tasks;
using OnlineExamSystem.Models.TokenAuth;
using OnlineExamSystem.Web.Controllers;
using Shouldly;
using Xunit;

namespace OnlineExamSystem.Web.Tests.Controllers
{
    public class HomeController_Tests: OnlineExamSystemWebTestBase
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