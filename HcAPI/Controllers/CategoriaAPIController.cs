using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Repository;

namespace HcAPI.Controllers
{
    [Route("apddi/Categoria")]
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

    }
}