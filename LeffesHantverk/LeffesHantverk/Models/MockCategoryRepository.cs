using System.Collections.Generic;

namespace LeffesHantverk.Models
{
    public class MockCategoryRepository: ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Träfigurer", Description="Täljda för hand"},
               
           
            };
    }
}
