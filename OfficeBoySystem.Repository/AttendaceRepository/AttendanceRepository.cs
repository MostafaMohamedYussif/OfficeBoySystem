using Microsoft.EntityFrameworkCore;
using OfficeBoySystem.Data.Data;
using OfficeBoySystem.Data.Entities;
using OfficeBoySystem.Repository;
using OfficeBoySystem.Repository.AttendaceRepository;

public class AttendanceRepository : BaseRepository ,IAttendanceRepository 
{
    private readonly ApplicationDbContext _context;

    public AttendanceRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<Attendance> GetAll()
    {
        return _context.Attendances.ToList();
    }

    public Attendance GetById(int id)
    {
        return _context.Attendances.FirstOrDefault(a => a.Id == id);
    }

    public void Create(Attendance attendance)
    {
        _context.Attendances.Add(attendance);
        _context.SaveChanges();
    }

    public void Update(Attendance attendance)
    {
        _context.Attendances.Update(attendance); 
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var attendance = _context.Attendances.Find(id);
        if (attendance != null)
        {
            _context.Attendances.Remove(attendance);
            _context.SaveChanges();
        }
    }
}
