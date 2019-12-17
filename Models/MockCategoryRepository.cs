using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackeryShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
           new List<Category>
           {
                new Category{CategoryId=1, CategoryName="Fruit pies", Description="All fruit is "},
                new Category{CategoryId=2, CategoryName="Fruit pies", Description="All fruit is "},
                new Category{CategoryId=3, CategoryName="Fruit pies", Description="All fruit is "}
           };
    }
}
