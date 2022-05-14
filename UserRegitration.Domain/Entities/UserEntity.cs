namespace UserRegitration.Domain.Entities
{
    public class UserEntity : EntityBase
    {
        public string Login { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }

        public string Tel { get; set; }


        public UserEntity(string login, string password, string email, string tel)
        {
            Login = login;
            Password = password;
            Email = email;
            Tel = tel;
        }
    }
}