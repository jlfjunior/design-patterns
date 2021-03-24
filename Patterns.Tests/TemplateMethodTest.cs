using Patterns.Models.TemplateMethod;
using Xunit;

namespace Patterns.Tests
{
    public class TemplateMethodTest
    {
        [Fact]
        public void ShouldSignIn()
        {
            var user = new User("admin@email.com", "123456", ServerType.Gmail);

            var login = new GoogleAuth();
            _ = login.SignIn(user);
            var information = login.GetUserInformation();

            Assert.NotNull(information);
            Assert.Equal(user.Email, information.Email);
            Assert.Equal(user.ServerType, information.ServerType);
        }

        [Fact]
        public void ShouldNotSignIn()
        {
            var user = new User("admin@email.com", "123456", ServerType.Gmail);

            var login = new GitHubAuth();
            _ = login.SignIn(user);
            var information = login.GetUserInformation();

            Assert.Null(information);
        }
    }
}
