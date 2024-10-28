namespace OfficeBoySystem.Data.Entities
{
    public class Building
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn {get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }
        public int CityId { get; set; }
       
    }
}
