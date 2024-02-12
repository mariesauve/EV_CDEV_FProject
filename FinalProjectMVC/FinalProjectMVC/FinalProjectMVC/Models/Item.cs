namespace FinalProjectMVC.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string? Description { get; set; }

        public int Supplier {  get; set; }

        public int Product { get; set; }
        public string? VSN { get; set; }

        public string? Location { get; set; }
    }
}
