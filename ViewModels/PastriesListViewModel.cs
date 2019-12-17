using System.Collections.Generic;
using BackeryShop.Models;

namespace BackeryShop.ViewModels
{
    public class PastriesListViewModel
    {
        public IEnumerable<Pie> Pastries { get; set; }
        public string CurrentCategory { get; set; }
    }
}
