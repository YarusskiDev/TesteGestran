namespace TesteGestranApi.Models
{
    public class Adress : Entity
    {
        public int? Id_Provider { get; set; }
        public string ZipCode { get; set; }
        public string Street { get; set; }
        public string Complement { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int Number { get; set; }

        public Provider Provider { get; set; }
    }
}
