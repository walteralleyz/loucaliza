using LoucaLiza.model.cliente;
using Loucaliza.model.veiculo;
using System;

namespace LoucaLiza.model.locacao
{
    public class Locacao
    {
        public int? Id { get; set; }
        public DateTime DataLocacao { get; set; }
        public DateTime DataDevolucao { get; set; }
        public double ValorDiario { get; set; }
        public int Dias { get; set; }
        public Cliente Cliente { get; set; }
        public Veiculo Veiculo { get; set; }
    }
}
