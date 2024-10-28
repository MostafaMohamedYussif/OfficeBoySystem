using Microsoft.EntityFrameworkCore;
using OfficeBoySystem.Data.Data;
using OfficeBoySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.UserTypeRepository
{
    public class UserTypeRepository : IUserTypeRepository
    {
        private readonly ApplicationDbContext _context;

        public UserTypeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<UserType> GetAll()
        {
            return _context.UserTypes.ToList();
        }

        public UserType GetById(int id)
        {
            return _context.UserTypes.FirstOrDefault(ut => ut.Id == id);
        }

        public void Create(UserType userType)
        {
            _context.UserTypes.Add(userType);
            _context.SaveChanges();
        }

        public void Update(UserType userType)
        {
            _context.UserTypes.Update(userType); 
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var userType = _context.UserTypes.Find(id);
            if (userType != null)
            {
                _context.UserTypes.Remove(userType);
                _context.SaveChanges();
            }
        }
    }


}
