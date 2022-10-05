using System.Collections.Generic;

namespace LeffesHantverk.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public List<WoodenHandcraft> WoodenHandcrafts { get; set; }
    }
}
