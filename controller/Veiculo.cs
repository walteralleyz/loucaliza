using System.Collections.Generic;
using Loucaliza.model.veiculo;

namespace Loucaliza.controller
{
    public class VeiculoController
    {
        private Repository<VeiculoModel> repository = new Repository<VeiculoModel>();

        public List<VeiculoModel> Listar()
        {
            return repository.GetAll();
        }
        
        public VeiculoModel Buscar(int id) {
            return repository.GetOneById(id);
        }

        public void Registrar(VeiculoModel model) {
            repository.CreateModel(model);
        }

        public void Atualizar(VeiculoModel model, int id) {
            repository.UpdateModel(model, id);
        }

        public void Apagar(int id) {
            VeiculoModel model = Buscar(id);
            repository.RemoveModel(model);
        }

    }
}


