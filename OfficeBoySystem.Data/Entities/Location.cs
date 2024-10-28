namespace OfficeBoySystem.Data.Entities
{
    public class Location
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string? NoteAr { get; set; }
        public string? NoteEn { get; set; }
        public int FloorId { get; set; }
        //Navigation Prop
       

    }
}
