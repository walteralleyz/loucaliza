using System;

namespace Loucaliza.model.cliente
{
    public class Endereco
    {
        public int id { get; set; }
        public string cep { get; set; }
        public string logradouro { get; set; }
        public string numero { get; set; }
        public string bairro { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
    }
}


