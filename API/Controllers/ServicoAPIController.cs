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
    [Route("api/Servico")]
    [ApiController]
    public class ServicoAPIController : ControllerBase
    {

        private readonly ServicoDAO _servicoDAO;
        private readonly CategoriaDAO _categoriaDAO;

        public ServicoAPIController(ServicoDAO servicoDAO, CategoriaDAO categoriaDAO)
        {
            _servicoDAO = servicoDAO;
            _categoriaDAO = categoriaDAO;
        }

        // /api/Servico/ListarTodos
        [HttpGet]
        [Route("ListarTodos")]
        public IActionResult ListarTodos()
        {
            return Ok(_servicoDAO.ListarTodos());
        }


        // /api/Servico/Cadastrar
        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Cadastrar([FromBody]Servico s)
        {
           
            if (ModelState.IsValid)
            {
                //_categoriaDAO.BuscarPorId(s.Categoria.CategoriaId);

                if (_servicoDAO.Cadastrar(s))
                {
                    return Created("", s);
                }
                return Conflict(new { msg = "Esse serviço já existe!" });
            }
            return BadRequest(ModelState);
        }


    }
}