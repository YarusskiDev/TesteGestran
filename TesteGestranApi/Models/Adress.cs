﻿namespace TesteGestranApi.Models
{
    public class Adress : Entity
    {
        public string Cep { get; set; }
        public string Rua { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Pais { get; set; }
        public int Numero { get; set; }

        public List<Provider> Provider { get; set; }
    }
}
