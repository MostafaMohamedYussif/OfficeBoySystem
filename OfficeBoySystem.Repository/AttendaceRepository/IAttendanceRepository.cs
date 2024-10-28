using Microsoft.EntityFrameworkCore.Internal;
using OfficeBoySystem.Data.Entities;
using OfficeBoySystem.Data.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeBoySystem.Repository.AttendaceRepository
{
    public interface IAttendanceRepository : IScoppedRepository
    {
        IEnumerable<Attendance> GetAll();
        Attendance GetById(int id);
        void Create(Attendance attendance);
        void Update(Attendance attendance);
        void Delete(int id);
    }

}
