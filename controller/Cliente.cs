using System.Collections.Generic;
using Loucaliza.model.cliente;

namespace Loucaliza.controller
{
    public class ClienteController
    {
        private Repository<ClienteModel> repository = new Repository<ClienteModel>();
        
        public List<ClienteModel> Listar()
        {
            return repository.GetAll();
        }

        public ClienteModel Buscar(int id) {
            return repository.GetOneById(id);
        }

        public void Registrar(ClienteModel model) {
            repository.CreateModel(model);
        }

        public void Atualizar(ClienteModel model, int id) {
            repository.UpdateModel(model, id);
        }

        public void Apagar(int id) {
            ClienteModel model = Buscar(id);
            repository.RemoveModel(model);
        }
    }
}


