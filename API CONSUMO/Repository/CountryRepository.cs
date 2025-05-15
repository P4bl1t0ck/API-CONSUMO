
using API_CONSUMO.Models;
using Newtonsoft.Json;

namespace API_CONSUMO.Repository

{
    public class CountryRepository
    {
        private HttpClient _httpClient;
        public CountryRepository()
        {
            _httpClient = new HttpClient();
            // _httpClient.BaseAddress = new Uri("https://restcountries.com/v3.1/");

        }
        // GET: api/<CountryRepository>
        public async Task<IEnumerable<Country>> GetCountryListAsync()
        {
           
                string url = "https://restcountries.com/v3.1/all";
                string response_json = await _httpClient.GetStringAsync(url);
                //Hasta aki estaba correcto
                List<Country> countries = JsonConvert.DeserializeObject<List<Country>>(response_json);
                return countries;
            
        }
    }
}
