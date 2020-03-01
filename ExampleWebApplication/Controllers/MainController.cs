using System.Web.Http;
using System.Web.Http.Cors;

namespace ExampleWebApplication.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class MainController : ApiController
    {
        public MainController()
        {  }
    }
}