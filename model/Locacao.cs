using System;
using Loucaliza;
using Loucaliza.model;
using Loucaliza.model.cliente;
using Loucaliza.model.veiculo;

namespace Loucaliza.model
{
    public class LocacaoModel
    {
        public int id { get; set; }
        public DateTime dataLocacao { get; set; }
        public DateTime dataDevolucao { get; set; }
        public double valorDiario { get; set; }
        public int dias { get; set; }
        public ClienteModel cliente { get; set; }
        public VeiculoModel veiculo { get; set; }
    }
}

