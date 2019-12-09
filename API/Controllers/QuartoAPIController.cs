using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuartoAPIController : ControllerBase
    {

        private readonly QuartoDAO _quartoDAO;
        public QuartoAPIController (QuartoDAO quartoDAO)
        {
            _quartoDAO = quartoDAO;
        }

        //GET: /api/Pet/BuscarPetPorCategoria/1
        [HttpGet]
        [Route("BuscarQuartoPorPreco/{preco}")]
        public IActionResult BuscarQuartoPorPreco([FromRoute] double preco)
        {
            List<Quarto> quartos =
                _quartoDAO.BuscarQuartoPorPreco(preco);

            if (quartos.Count > 0)
            {
                return Ok(quartos);
            }

            return NotFound(new { msg = "Nenhum quarto encontrado!" });
        }

    }
}