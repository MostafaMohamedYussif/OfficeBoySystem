using System.ComponentModel.DataAnnotations.Schema;

namespace OfficeBoySystem.Data.Entities
{
    public class Shift
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartTime { get; set; }
        public float ShiftHours { get; set; }

        // Calculated property for EndTime
        public DateTime EndTime => StartTime.ToUniversalTime().AddHours(ShiftHours);

        // Read-only property to calculate the hour count
        public double HourCount => (EndTime - StartTime.ToUniversalTime()).TotalHours;



    }
}
