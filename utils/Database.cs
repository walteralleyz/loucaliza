using System;
using System.Collections;
using Loucaliza;
using Loucaliza.model;
using Loucaliza.model.cliente;
using Loucaliza.model.veiculo;

namespace Loucaliza.utils
{
    public class Database
    {
        private static Hashtable database = new Hashtable();

        public static void InitDB()
        {
            database.Add("locacoes", new Repository<LocacaoModel>());
            database.Add("veiculos", new Repository<VeiculoModel>());
            database.Add("clientes", new Repository<ClienteModel>());
        }

        public static Repository<LocacaoModel> GetLocacaoRepo()
        {
            return database["locacoes"] as Repository<LocacaoModel>;
        }

        public static Repository<VeiculoModel> GetVeiculoRepo()
        {
            return database["veiculos"] as Repository<VeiculoModel>;
        }

        public static Repository<ClienteModel> GetClienteRepo()
        {
            return database["clientes"] as Repository<ClienteModel>;
        }
    }
}