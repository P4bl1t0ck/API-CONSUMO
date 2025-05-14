using System.Text.Json.Serialization;
using API_CONSUMO.Models;

namespace API_CONSUMO.NewFolder
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
            var response = await (_httpClient.GetStringAsync(url));
            List<Country> countries = JsonConverter.DeserializeObject<List<Country>>(response);
            return countries;
    }
}
