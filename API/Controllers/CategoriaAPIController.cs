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
    [Route("api/Categoria")]
    [ApiController]
    public class CategoriaAPIController : ControllerBase
    {

        private readonly CategoriaDAO _categoriaDAO;
        public CategoriaAPIController(CategoriaDAO categoriaDAO)
        {
            _categoriaDAO = categoriaDAO;
        }

        //GET: /api/Categoria/ListarTodos
        [HttpGet]
        [Route("ListarTodos")]
        public IActionResult ListarTodos()
        {
            return Ok(_categoriaDAO.ListarTodos());
        }


        // /api/Categoria/Cadastrar
        [HttpPost]
        [Route("Cadastrar")]
        public IActionResult Cadastrar([FromBody]Categoria c)
        {
            if (ModelState.IsValid)
            {
                if (_categoriaDAO.Cadastrar(c))
                {
                    return Created("", c);
                }
                return Conflict(new { msg = "Esse serviço já existe!" });
            }
            return BadRequest(ModelState);
        }


    }



}