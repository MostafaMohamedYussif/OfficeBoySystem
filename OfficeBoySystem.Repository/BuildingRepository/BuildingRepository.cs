using Microsoft.EntityFrameworkCore;
using OfficeBoySystem.Data.Data;
using OfficeBoySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.BuildingRepository
{
    public class BuildingRepository : IBuildingRepository
    {
        private readonly ApplicationDbContext _context;

        public BuildingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Building> GetAll()
        {
            return _context.Buildings.ToList();
        }

        public Building GetById(int id)
        {
            return _context.Buildings.FirstOrDefault(b => b.Id == id);
        }

        public void Create(Building building)
        {
            _context.Buildings.Add(building);
            _context.SaveChanges();
        }

        public void Update(Building building)
        {
            _context.Buildings.Update(building);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var building = _context.Buildings.Find(id);
            if (building != null)
            {
                _context.Buildings.Remove(building);
                _context.SaveChanges();
            }
        }
    }

}
