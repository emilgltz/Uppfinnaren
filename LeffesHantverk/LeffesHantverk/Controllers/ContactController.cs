

    using Microsoft.AspNetCore.Mvc;

    namespace LeffesHantverk.Controllers
    {
        public class ContactController : Controller
        {
            [HttpGet]
            public ViewResult Index()
            {
                return View();
            }
        }
    }
