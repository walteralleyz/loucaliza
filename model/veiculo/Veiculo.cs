using Loucaliza.model.enums;

namespace Loucaliza.model.veiculo
{
    public class VeiculoModel
    {
        public int id { get; set; }
        public string modelo { get; set; }
        public string placa { get; set; }
        public int ano { get; set; }
        public Cor cor { get; set; }
    }
}

