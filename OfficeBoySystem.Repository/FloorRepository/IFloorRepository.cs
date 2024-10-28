using OfficeBoySystem.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.FloorRepository
{
    public interface IFloorRepository
    {
        IEnumerable<Floor> GetAll();
        Floor GetById(int id);
        void Create(Floor floor);
        void Update(Floor floor);
        void Delete(int id);
    }

}
