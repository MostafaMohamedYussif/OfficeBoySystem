namespace OfficeBoySystem.Data.Entities
{
    public class Attendance
    {
        public int Id { get; set; }
        public DateTime LogInTime { get; set; }
        public DateTime? LogOutTime { get; set; }

        public string UserId { get; set; }
        public int ShiftId { get; set; }
        //Navigation prop
      
    }
}
