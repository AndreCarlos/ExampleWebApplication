using ExampleBusiness.Interfaces;
using ExampleBusiness.Models;
using MeuServicoWebApi.Models;
using System.Linq;
using System.Web.Http;

namespace ExampleWebApplication.Controllers
{
    public class ExampleController : MainController
    {
        private readonly IFornecedorExampleService _fornecedorRepository;
        private readonly FornecedorExample fornecedor;

        private readonly Cliente[] Clientes = new Cliente[]
       {
            new Cliente { ID = 1, Nome = "Eduardo Pires", Email = "falecom@eduardopires.net.br", Ativo = true },
            new Cliente { ID = 2, Nome = "Bill Gates", Email = "gates@microsoft.com", Ativo = true },
            new Cliente { ID = 3, Nome = "Aleister Crowley", Email = "aleister@therion.com", Ativo = false } 
       };


        [HttpGet]
        public IHttpActionResult  ObterTodos()
        {
            return Ok(Clientes);
            //return _fornecedorRepository.Adicionar(fornecedor);
        }

        [HttpGet]
        public Cliente ObterTodosPorID(int id)
        {
            return Clientes.SingleOrDefault(x => x.ID == id);
        }
    }
}
