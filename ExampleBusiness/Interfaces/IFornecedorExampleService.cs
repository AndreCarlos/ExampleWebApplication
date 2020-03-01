using ExampleBusiness.Models;
using System;

namespace ExampleBusiness.Interfaces
{
    public interface IFornecedorExampleService : IDisposable
    {
        void Adicionar(FornecedorExample fornecedor);
    }
}
