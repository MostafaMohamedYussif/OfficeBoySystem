using Microsoft.EntityFrameworkCore;
using OfficeBoySystem.Data.Data;
using OfficeBoySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.DrinkRepository
{
    public class DrinkRepository : IDrinkRepository
    {
        private readonly ApplicationDbContext _context;

        public DrinkRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Drink> GetAll()
        {
            return _context.Drinks.ToList();
        }

        public Drink GetById(int id)
        {
            return _context.Drinks.FirstOrDefault(d => d.Id == id);
        }

        public void Create(Drink drink)
        {
            _context.Drinks.Add(drink);
            _context.SaveChanges();
        }

        public void Update(Drink drink)
        {
            _context.Drinks.Update(drink);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var drink = _context.Drinks.Find(id);
            if (drink != null)
            {
                _context.Drinks.Remove(drink);
                _context.SaveChanges();
            }
        }
    }

}
