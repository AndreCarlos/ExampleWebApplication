using DevIO.Business.Models;
using System;

namespace ExampleBusiness.Interfaces
{
    interface IExampleRepository<TEntity> : IDisposable where TEntity : Entity
    {
        void Adicionar(TEntity entity);
    }
}
