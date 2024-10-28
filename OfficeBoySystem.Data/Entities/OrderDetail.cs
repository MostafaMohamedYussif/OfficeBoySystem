namespace OfficeBoySystem.Data.Entities
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }
        public int OrderId { get; set; }
        public int DrinkId { get; set; }
        //Navigation prop

    }
}
