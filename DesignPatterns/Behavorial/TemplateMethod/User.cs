namespace DesignPatterns.Behavorial.TemplateMethod
{
    public class User
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public ServerType ServerType { get; set; }

        public User(string email, string password, ServerType serverType)
        {
            Email = email;
            Password = password;
            ServerType = serverType;
        }
    }

    public enum ServerType
    {
        Gmail = 1,
        GitHub = 2
    }
}
