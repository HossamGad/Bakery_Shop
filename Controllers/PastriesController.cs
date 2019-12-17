
using Microsoft.AspNetCore.Mvc;
using BackeryShop.Models;
using BackeryShop.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Pies.Models.Controllers
{
    public class PastriesController : Controller
    {
        private readonly IPastriesRepository _pastriesRepository;
        private readonly ICategoryRepository _categoryRepository;

        public PastriesController(IPastriesRepository pasteriesRepository, ICategoryRepository categoryRepository)
            {
            _pastriesRepository = pasteriesRepository;
            _categoryRepository = categoryRepository;
            }

        public ViewResult List()
        {
            PastriesListViewModel pasteriesListViewModel = new PastriesListViewModel
            {
                Pastries = _pastriesRepository.AllPastries
            };
            return View(pasteriesListViewModel);

        }
    }
}
