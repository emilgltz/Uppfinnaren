using System.Collections.Generic;
using System.Linq;

namespace LeffesHantverk.Models
{
    public class MockWoodenHandcraftRepository: IWoodenHandcraftRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<WoodenHandcraft> AllWoodenHandcrafts =>
            new List<WoodenHandcraft>
            {  // adding woodfigures to its category
                new WoodenHandcraft {WoodenHandcraftId = 1, Name="Bröderna Spik", Price=199M, Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://h24-original.s3.amazonaws.com/63527/4632431-9mdy7.jpg"},
                new WoodenHandcraft {WoodenHandcraftId = 2, Name="Trollflickor", Price=129M, Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://dst15js82dk7j.cloudfront.net/63527/72672701-YCrV7.jpg"},
                new WoodenHandcraft {WoodenHandcraftId = 3, Name="Detetktiven Lenartsson", Price=99M, Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://dst15js82dk7j.cloudfront.net/63527/72672700-eKJrE.jpg"},
                
            };

        

        public WoodenHandcraft GetWoodenHandcraftById(int woodenHandcraftId)
        {
            return AllWoodenHandcrafts.FirstOrDefault(p => p.WoodenHandcraftId == woodenHandcraftId);
        }
    }
}
