namespace FinalProjectMVC.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int CustomerId { get; set; }
        public int ItemId { get; set; }
        
        public int? EmployeeId { get; set; }
        public int Quantity { get; set; }

        public decimal Price { get; set; }

        public DateTime DateTime { get; set; }
    }
}
