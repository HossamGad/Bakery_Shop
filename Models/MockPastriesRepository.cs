using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BackeryShop.Models
{
    public class MockPastriesRepository: IPastriesRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Pie> AllPastries =>
            new List<Pie>
            {

            new Pie{PastriesID=1, Name="Blueberry Pie", ShortDescription="This is a Blueberry Pie", Price=12, Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://www.google.se/imgres?imgurl=https%3A%2F%2Fi.ytimg.com%2Fvi%2FeHKwEX1ees8%2Fmaxresdefault.jpg&imgrefurl=https%3A%2F%2Fwww.inspiredtaste.net%2F23159%2Fhomemade-blueberry-pie-recipe%2F&docid=GDJcJXoKLXESbM&tbnid=7giOyYE-fJycYM%3A&vet=10ahUKEwjLz_OjsbzmAhXKwqYKHQD6ArAQMwhCKAMwAw..i&w=1280&h=720&bih=623&biw=1366&q=blueberry%20pie&ved=0ahUKEwjLz_OjsbzmAhXKwqYKHQD6ArAQMwhCKAMwAw&iact=mrc&uact=8.jpg", InStock=true, IsPieOfTheWeek=false, ImageThumbnailUrl="https://www.google.se/imgres?imgurl=https%3A%2F%2Fi.ytimg.com%2Fvi%2FeHKwEX1ees8%2Fmaxresdefault.jpg&imgrefurl=https%3A%2F%2Fwww.inspiredtaste.net%2F23159%2Fhomemade-blueberry-pie-recipe%2F&docid=GDJcJXoKLXESbM&tbnid=7giOyYE-fJycYM%3A&vet=10ahUKEwjLz_OjsbzmAhXKwqYKHQD6ArAQMwhCKAMwAw..i&w=1280&h=720&bih=623&biw=1366&q=blueberry%20pie&ved=0ahUKEwjLz_OjsbzmAhXKwqYKHQD6ArAQMwhCKAMwAw&iact=mrc&uact=8.jpg"},
            new Pie{PastriesID=2, Name="Chokolade Pie", ShortDescription="This is a Chokolade Pie", Price=13},
            new Pie{PastriesID=3, Name="Cheese Cake", ShortDescription="This is a Cheese Cake", Price=14},
            new Pie{PastriesID=4, Name="Brownie", ShortDescription="This is a Brownie", Price=15},
            new Pie{PastriesID=5, Name="Apple Pie", ShortDescription="This is a Apple Pie", Price=16},
            new Pie{PastriesID=6, Name="Kiwi Pie", ShortDescription="This is a Kiwi Pie", Price=17}
            };

        public IEnumerable<Pie> PastriesOfTheWeek { get; }

        public Pie GetPastriesById(int pastriesId)
        {
            return AllPastries.FirstOrDefault(p => p.PastriesId == pastriesId);
        }
    }
}

