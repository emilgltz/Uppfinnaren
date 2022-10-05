using System.Collections.Generic;

namespace LeffesHantverk.Models
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> AllCategories { get; }

    }
}
