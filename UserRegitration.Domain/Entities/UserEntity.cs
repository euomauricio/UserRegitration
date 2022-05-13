namespace UserRegitration.Domain.Entities
{
    public class UserEntity : EntityBase
    {
        public string Login { get; set; }

        public string Password { get; set; }

        public UserEntity(string login, string password)
        {
            Login = login;
            Password = password;
        }
    }
}