namespace DaprService.Models
{
    public class Item
    {
        public Guid ItemId { get; set; }
        public string Name { get; set; } = String.Empty;
        public int Price { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; } = String.Empty;
    }
}
