using UserRegitration.Domain.Entities;

namespace UserRegitration.Infrastructure.Interfaces
{
    public interface IUserRepository : IRepositoryAsync<UserEntity> { }
}
