using System.Collections.Generic;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{

    [RoutePrefix("api/usuario")]
    public class UsuarioController : ApiController
    {
        

        [AcceptVerbs("GET")]
        [Route("teste")]
        public string CadastrarUsuario()
        {

            return "Usuário cadastrado com sucesso!";
        }

        
    }
}