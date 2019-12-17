using System.Collections.Generic;

namespace BackeryShop.Models
{
    public interface IPastriesRepository
    {
        IEnumerable<Pie> AllPastries { get; }
        IEnumerable<Pie> PastriesOfTheWeek { get; }
        Pie GetPastriesById(int pastriesId);
    }
}
