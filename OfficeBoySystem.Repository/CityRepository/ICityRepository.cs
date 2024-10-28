using OfficeBoySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.CityRepository
{
    public interface ICityRepository
    {
        IEnumerable<City> GetAll();
        City GetById(int id);
        void Create(City city);
        void Update(City city);
        void Delete(int id);
    }

}
