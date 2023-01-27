using Newtonsoft.Json;

namespace TesteGestranApi.Models
{
    public class Provider:Entity
    {
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        [JsonIgnore]
        public List<Adress> Adresses { get; set; }
    }
}
