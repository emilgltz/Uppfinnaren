using LeffesHantverk.Models;
using LeffesHantverk.ViewModels;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LeffesHantverk.Controllers
{
    public class WoodenHandcraftController : Controller
    {
        private readonly IWoodenHandcraftRepository _woodenHandcraftRepository;
        private readonly ICategoryRepository _categoryRepository;

        public WoodenHandcraftController(IWoodenHandcraftRepository woodenHandcraftRepository, ICategoryRepository categoryRepository)
        {
            _woodenHandcraftRepository = woodenHandcraftRepository;
            _categoryRepository = categoryRepository;
        }

        // GET: /<controller>/
        public IActionResult List()
        {
            //ViewBag.CurrentCategory = "Cheese cakes";

            //return View(_pieRepository.AllPies);
            WoodenHandcraftsListViewModel woodenHandcraftsListViewModel = new WoodenHandcraftsListViewModel();
            woodenHandcraftsListViewModel.WoodenHandcrafts = _woodenHandcraftRepository.AllWoodenHandcrafts;

            woodenHandcraftsListViewModel.CurrentCategory = "Träfigurer";
            return View(woodenHandcraftsListViewModel);
        }
    }
}
