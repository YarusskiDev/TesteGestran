using System.ComponentModel;
using System.Text.Json.Serialization;

namespace TesteGestranApi.Models
{
    public class Provider:Entity
    {
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }
        public virtual List<Adress> Adresses { get; set; }
    }
}
