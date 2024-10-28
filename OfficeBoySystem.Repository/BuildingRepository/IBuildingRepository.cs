using OfficeBoySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.BuildingRepository
{
    public interface IBuildingRepository
    {
        IEnumerable<Building> GetAll();
        Building GetById(int id);
        void Create(Building building);
        void Update(Building building);
        void Delete(int id);
    }

}
