using System;

namespace LoucaLiza.model.cliente
{
    public class Cliente
    {
        public int? Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public Telefone Telefone { get; set; }
        public Endereco Endereco { get; set; }
    }
}
