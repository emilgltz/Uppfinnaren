using System.Collections.Generic;
using LeffesHantverk.Models;

namespace LeffesHantverk.ViewModels
{
    public class WoodenHandcraftsListViewModel
    {
        public IEnumerable<WoodenHandcraft> WoodenHandcrafts { get; set; }
        public string CurrentCategory { get; set; }
    }
}
