using OfficeBoySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.DrinkRepository
{
    public interface IDrinkRepository
    {
        IEnumerable<Drink> GetAll();
        Drink GetById(int id);
        void Create(Drink drink);
        void Update(Drink drink);
        void Delete(int id);
    }

}
