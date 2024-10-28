using OfficeBoySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.UserTypeRepository
{
    public interface IUserTypeRepository
    {
        IEnumerable<UserType> GetAll();
        UserType GetById(int id);
        void Create(UserType userType);
        void Update(UserType userType);
        void Delete(int id);
    }
}
