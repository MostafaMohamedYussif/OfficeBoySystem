namespace OfficeBoySystem.Data.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string EmpolyeeId { get; set; }
        public int ShiftId { get; set; }

        public int LocationId { get; set; }
        public string OfficeBoyId { get; set; }
        public bool IsIndividual { get; set; }
        public int OrderStatusId { get; set; }
        public DateTime OrderDate { get; set; }
        public double TotalPrice { get; set; }
        //Navigation prop
        
    }
}
