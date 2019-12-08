using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace HotelCachorroAPI.Controllers
{
    [Route("api/Servico")]
    [ApiController]
    public class ServicoAPIController : ControllerBase
    {

        private readonly ServicoDAO _servicoDAO;
        public ServicoAPIController(ServicoDAO servicoDAO)
        {
            _servicoDAO = servicoDAO;
        }



    }
}