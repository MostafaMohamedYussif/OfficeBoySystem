using Microsoft.EntityFrameworkCore;
using OfficeBoySystem.Data.Data;
using OfficeBoySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.FloorRepository
{
    public class FloorRepository : IFloorRepository
    {
        private readonly ApplicationDbContext _context;

        public FloorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Floor> GetAll()
        {
            return _context.Floors.ToList();
        }

        public Floor GetById(int id)
        {
            return _context.Floors.FirstOrDefault(f => f.Id == id);
        }

        public void Create(Floor floor)
        {
            _context.Floors.Add(floor);
            _context.SaveChanges();
        }

        public void Update(Floor floor)
        {
            _context.Floors.Update(floor);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var floor = _context.Floors.Find(id);
            if (floor != null)
            {
                _context.Floors.Remove(floor);
                _context.SaveChanges();
            }
        }
    }

}
