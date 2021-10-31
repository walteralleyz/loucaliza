using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;

namespace Loucaliza
{
    public class Repository<T>
    {
        private List<T> models;

        public Repository() {
            this.models = new List<T>();
        }

        public List<T> GetAll() {
            return models;
        }

        public void CreateModel(T model)
        {
            models.Add(model);
        }

        public T GetOneById(int id)
        {
            return models[id];
        }

        public void RemoveModel(T model)
        {
            models.Remove(model);
        }

        public void UpdateModel(T model, int id)
        {
            models[id] = model;
        }
    }
}