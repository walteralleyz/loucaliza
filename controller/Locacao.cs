using System;
using System.Collections;
using System.Collections.Generic;
using Loucaliza;
using Loucaliza.utils;
using Loucaliza.model;

namespace Loucaliza.controller
{
    public class LocacaoController
    {
        private Repository<LocacaoModel> repository = Database.GetLocacaoRepo();

        public List<LocacaoModel> Listar()
        {
            return repository.GetAll();
        }

        public LocacaoModel Buscar(int id) {
            return repository.GetOneById(id);
        }

        public void Registrar(LocacaoModel model) {
            repository.CreateModel(model);
        }

        public void Atualizar(LocacaoModel model, int id) {
            repository.UpdateModel(model, id);
        }

        public void Apagar(int id) {
            LocacaoModel model = Buscar(id);
            repository.RemoveModel(model);
        }

    }
}


