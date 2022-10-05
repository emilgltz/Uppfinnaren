namespace LeffesHantverk.Models
{
    public class WoodenHandcraft
    {
        public int WoodenHandcraftId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
