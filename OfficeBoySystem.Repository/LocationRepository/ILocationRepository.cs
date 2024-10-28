using OfficeBoySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.LocationRepository
{
    public interface ILocationRepository
    {
        IEnumerable<Location> GetAll();
        Location GetById(int id);
        void Create(Location location);
        void Update(Location location);
        void Delete(int id);
    }

}
