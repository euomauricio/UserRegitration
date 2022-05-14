using UserRegitration.Application.Dto;
using UserRegitration.Application.Interfaces;
using UserRegitration.Domain.Entities;
using UserRegitration.Infrastructure.Interfaces;

namespace UserRegitration.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;

        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public void Add(string login, string password, string email, string tel)=> _repository.Add(new Domain.Entities.UserEntity(login, password, email, tel));

        public async Task<List<UserDto>> Get()
        {
            var result = await _repository.Get();

            return result.Select(x => new UserDto(x.Id, x.Login, x.Password, x.Email, x.Tel)).ToList(); 
        }



        public async Task<UserDto> GetById(Guid id)
        {
            var result = await _repository.GetByGuid(id);

            return new UserDto(result.Id, result.Login, result.Password, result.Email, result.Tel);
        }
    }
}
