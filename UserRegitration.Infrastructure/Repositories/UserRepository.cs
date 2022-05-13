using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserRegitration.Domain.Entities;
using UserRegitration.Infrastructure.Context;
using UserRegitration.Infrastructure.Interfaces;

namespace UserRegitration.Infrastructure.Repositories
{
    public class UserRepository : RepositoryBase<UserEntity>, IUserRepository
    {
        public UserRepository(UserRegistrationContext context) : base(context)
        {
        }
    }
}
