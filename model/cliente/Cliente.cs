using System;

namespace Loucaliza.model.cliente
{
    public class ClienteModel
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string email { get; set; }
        public DateTime dataNascimento { get; set; }
        public Telefone telefone { get; set; }
        public Endereco endereco { get; set; }
    }
}


