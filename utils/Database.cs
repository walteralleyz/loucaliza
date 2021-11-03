using System.Collections;
using Loucaliza.model.veiculo;
using LoucaLiza.model.cliente;
using LoucaLiza.model.locacao;

namespace Loucaliza.utils
{
    public class Database
    {
        private static Hashtable database = new Hashtable();

        public static void InitDB()
        {
            database.Add("locacoes", new Repository<Locacao>());
            database.Add("veiculos", new Repository<Veiculo>());
            database.Add("clientes", new Repository<Cliente>());
        }

        public static Repository<Locacao> GetLocacaoRepo()
        {
            return database["locacoes"] as Repository<Locacao>;
        }

        public static Repository<Veiculo> GetVeiculoRepo()
        {
            return database["veiculos"] as Repository<Veiculo>;
        }

        public static Repository<Cliente> GetClienteRepo()
        {
            return database["clientes"] as Repository<Cliente>;
        }
    }
}
