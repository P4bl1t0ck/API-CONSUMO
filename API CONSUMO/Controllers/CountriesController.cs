using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_CONSUMO.Repository;
namespace API_CONSUMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountriesController : ControllerBase
    {
        private CountryRepository _repo;

        [HttpGet]
        public IActionResult GetCountryList()
        {

        }
    }
}
