namespace TesteGestranApi.Models
{
    public class Provider:Entity
    {
        public int Id_Adress { get; set; }
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Telephone { get; set; }
        public string Email { get; set; }

        public Adress Adress { get; set; }
    }
}
