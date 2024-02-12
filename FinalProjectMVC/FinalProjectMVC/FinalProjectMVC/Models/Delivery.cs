namespace FinalProjectMVC.Models
{
    public class Delivery
    {
        public int Id { get; set; }
        public int DeliveryId { get; set; }
        public string? Notes { get; set; }
        public string? DeliveryDate { get; set; }
        public int? CustomerId { get; set; }

    }
}
