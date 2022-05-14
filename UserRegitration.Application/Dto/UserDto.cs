using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserRegitration.Application.Dto
{
    public class UserDto
    {
        public Guid Id { get; set; }

        public string Login { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }

        public string Tel { get; set; }

        public UserDto(Guid id, string login, string password, string email, string tel)
        {
            this.Id = id;
            Login = login;
            Password = password;
            Email = email;
            Tel = tel;

        }
    }
}
