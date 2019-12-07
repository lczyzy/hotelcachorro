using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Domain;
using Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Xml.Serialization;
using Newtonsoft.Json.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

namespace EcommerceAngelo.Controllers
{
    public class ClienteController : Controller
    {
        private readonly ClienteDAO _clienteDAO;
        private readonly GeneroDAO _generoDAO;
        private readonly IHostingEnvironment _hosting;
        public ClienteController(ClienteDAO clienteDAO, GeneroDAO generoDAO, IHostingEnvironment hosting)
        {
            _clienteDAO = clienteDAO;
            _generoDAO = generoDAO;
            _hosting = hosting;
        }

        [HttpPost]
        public IActionResult Cadastrar(int drpGeneros, Cliente c)
        {
            ViewBag.Generos =
                new SelectList(_generoDAO.ListarTodos(),
                "GeneroId", "Nome");

            if (ModelState.IsValid)
            {
              

                c.Genero =
                    _generoDAO.BuscarPorId(drpGeneros);

                



                if (_clienteDAO.Cadastrar(c))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError
                    ("", "Esse cliente já existe!");
            }
            return View(c);
        }

        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_clienteDAO.ListarTodos());
        }

        public IActionResult Cadastrar()
        {

            ViewBag.Generos =
                new SelectList(_generoDAO.ListarTodos(),
                "GeneroId", "Nome");

            Cliente c = new Cliente();
            if (TempData["Cliente"] != null)
            {
                string resultado = TempData["Cliente"].ToString();

                //Endereco endereco = JsonConvert.DeserializeObject<Endereco>(resultado);

                c.Endereco = JsonConvert.DeserializeObject<Endereco>(resultado);
         
            }

            return View(c);
        }



        [HttpPost]
        public IActionResult BuscarCep(Cliente c)
        {

            var correios = new ServiceReference1.AtendeClienteClient();
           

            var consulta = correios.consultaCEPAsync(c.Endereco.Cep).Result;



            if (consulta != null)
            {
                TempData["Cliente"] = JsonConvert.SerializeObject(consulta);
 

                return RedirectToAction(nameof(Cadastrar));
            }

            ModelState.AddModelError
                    ("", "BuscarCep inválido!");
            return View(c);
        }




        public IActionResult Remover(int id)
        {
            _clienteDAO.Remover(id);
            return RedirectToAction("Index");
        }

        public IActionResult Alterar(int id)
        {
            return View
                (_clienteDAO.BuscarPorId(id));
        }

        [HttpPost]
        public IActionResult Alterar(Cliente c)
        {
            _clienteDAO.Alterar(c);
            return RedirectToAction("Index");
        }

       

        [HttpPost]
        public IActionResult BuscarCliente(string cpf)
        {
            var cliente = _clienteDAO.BuscarClientePorCpf(cpf);

            if (cliente != null)
            {
                return View();
            }

            return null;
        }
    }
}
