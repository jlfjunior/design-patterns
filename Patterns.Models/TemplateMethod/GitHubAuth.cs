namespace Patterns.Models.TemplateMethod
{
    public class GitHubAuth : Login
    {
        public override bool SignIn(User user)
        {
            if (user.ServerType != ServerType.GitHub) return IsAuthenticated();

            User = user;

            return IsAuthenticated();
        }
    }
}
