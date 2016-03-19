using SST.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SST.Repositories.Intefaces
{
    public interface IUserRepository
    {
        User GetUserByLogin(string login, string password);
    }
}
