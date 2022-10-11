namespace DesignPatterns.Behavorial.TemplateMethod
{
    public class GoogleAuth : Login
    {
        public override bool SignIn(User user)
        {
            if (user.ServerType != ServerType.Gmail) return IsAuthenticated();

            User = user;

            return IsAuthenticated();
        }
    }
}
