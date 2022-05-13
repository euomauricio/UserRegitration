using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegitration.Application.Dto;

namespace UserRegitration.Application.Interfaces
{
    public interface IUserService
    {
        void Add(string login, string password);

        Task<List<UserDto>> Get();

        Task<UserDto> GetById(Guid id);
        

    }
}
