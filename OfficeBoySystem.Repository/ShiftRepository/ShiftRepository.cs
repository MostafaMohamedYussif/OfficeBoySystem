using Microsoft.EntityFrameworkCore;
using OfficeBoySystem.Data.Data;
using OfficeBoySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.ShiftRepository
{
    public class ShiftRepository : IShiftRepository
    {
        private readonly ApplicationDbContext _context;

        public ShiftRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Shift> GetAll()
        {
            return _context.Shifts.ToList();
        }

        public Shift GetById(int id)
        {
            return _context.Shifts.FirstOrDefault(s => s.Id == id);
        }

        public void Create(Shift shift)
        {
            _context.Shifts.Add(shift);
            _context.SaveChanges();
        }

        public void Update(Shift shift)
        {
            _context.Shifts.Update(shift); 
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var shift = _context.Shifts.Find(id);
            if (shift != null)
            {
                _context.Shifts.Remove(shift);
                _context.SaveChanges();
            }
        }
    }




}
