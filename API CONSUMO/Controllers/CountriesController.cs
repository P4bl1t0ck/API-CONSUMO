using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using API_CONSUMO.Repository;
using System.Threading.Tasks;
namespace API_CONSUMO.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //This exact part is what i fix with the classroom record.

    public class CountriesController : ControllerBase
    {
        private CountryRepository _repo;
        //Constructor de la clase
        public CountriesController()
        {
            //traremos la informacion de nuestro repositorio.
            _repo = new CountryRepository();
        }

        [HttpGet]
        //Fucnion de get countrie list.
        public async Task<IActionResult> GetCountryList()
        {
            try
            {
                var countries = await _repo.GetCountryListAsync();
                return Ok(countries);
            }
            catch (Exception)
            {
                return StatusCode(500);
            }
        }
    }
}
