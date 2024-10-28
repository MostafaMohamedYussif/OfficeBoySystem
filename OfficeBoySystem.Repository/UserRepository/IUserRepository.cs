using OfficeBoySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.UserRepository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAll();
        User GetById(string id);
        void Create(User user);
        void Update(User user);
        void Delete(string id);
    }

}
