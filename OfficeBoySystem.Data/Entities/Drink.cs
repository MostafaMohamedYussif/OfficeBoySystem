namespace OfficeBoySystem.Data.Entities
{
    public class Drink
    {
        public int Id { get; set; }
        public string NameAr { get; set; }
        public string NameEn { get; set; }

        public string DescriptionAr { get; set; }
        public string DescriptionEn { get; set; }

        public double Price { get; set; }
        public string PictureUrl { get; set; }
        public bool IsAvailable { get; set; }
        public ushort TimeToBeReady { get; set; }
        //Navigation prop
      
    }
}
