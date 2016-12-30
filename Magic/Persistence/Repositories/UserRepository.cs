using Magic.Core.Repositories;
using Magic.Data.Models;
using System.Data.Entity;
using System.Linq;
using System.Collections.Generic;

namespace Magic.Persistence.Repositories
{
    public class UserRepository : Repository<User, int>, IUserRepository
    {
        public UserRepository(PlutoContext context) : base(context)
        {

        }
    }
}
