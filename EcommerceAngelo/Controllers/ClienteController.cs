﻿using System;
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
        public IActionResult Cadastrar(Cliente c,
            int drpGeneros, IFormFile fupImagem)
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
        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Generos =
                new SelectList(_generoDAO.ListarTodos(),
                "GeneroId", "Nome");
            return View();
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
    }
}
