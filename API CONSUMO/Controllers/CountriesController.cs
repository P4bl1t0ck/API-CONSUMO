using Microsoft.AspNetCore.Mvc;

namespace API_CONSUMO.Controllers
{
    public class CountriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
