namespace API_CONSUMO.Models
{
    public class Country
    {
        public countryName name { get; set; }
        public Boolean independent { get; set; }
        public string region { get; set; }
        public string subregion { get; set; }

    }
    public class  countryName
    {
        public string common { get; set; }
        public string official { get; set; }

    }
}
