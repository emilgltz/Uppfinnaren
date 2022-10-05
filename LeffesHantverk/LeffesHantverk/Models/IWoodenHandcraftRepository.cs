using System.Collections.Generic;

namespace LeffesHantverk.Models
{
    public interface IWoodenHandcraftRepository
    {
        IEnumerable<WoodenHandcraft> AllWoodenHandcrafts { get; }
        WoodenHandcraft GetWoodenHandcraftById(int woodenHandcraftId);
    }
}
