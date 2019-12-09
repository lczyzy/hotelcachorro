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
    [Route("api/Pet")]
    [ApiController]
    public class PetAPIController : ControllerBase
    {

        private readonly PetDAO _petDAO;

        public PetAPIController(PetDAO petDAO)
        {
            _petDAO = petDAO;
        }


        //GET: /api/Pet/ListarTodos
        [HttpGet]
        [Route("ListarTodos")]
        public IActionResult ListarTodos()
        {
            return Ok(_petDAO.ListarTodos());
        }


        //GET: /api/Pet/BuscarPetPorCategoria/1
        [HttpGet]
        [Route("BuscarPetPorCliente/{id}")]
        public IActionResult BuscarPorCategoria([FromRoute] int id)
        {
            List<Pet> pets =
                _petDAO.ListarPetPorCliente(id);
            if (pets.Count > 0)
            {
                return Ok(pets);
            }

            return NotFound(new { msg = "Nenhum pet encontrado!" });
        }






    }
}