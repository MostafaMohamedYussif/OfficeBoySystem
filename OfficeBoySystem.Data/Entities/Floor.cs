namespace OfficeBoySystem.Data.Entities
{
    public class Floor
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }
        public string ImageUrl { get; set; }
        public int BuildingId { get; set; }
        //Navigation prop
     
    }
}
