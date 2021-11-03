namespace Loucaliza.model.veiculo
{
    public class Veiculo
    {
        public int? Id { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public int Ano { get; set; }
        public Cor Cor { get; set; }
        public string Chassi { get; set; }
        public int Quilometragem { get; set; }
        public decimal ValorDiario { get; set; }
        public bool Locado { get; set; }
    }
}
