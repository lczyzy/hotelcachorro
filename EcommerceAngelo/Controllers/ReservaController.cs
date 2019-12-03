using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelCachorro.Model;
using Repository;

namespace EcommerceAngelo.Controllers
{
    public class ReservaController : Controller
    {
        
        private readonly PetDAO _petDAO;
        private readonly ReservaDAO _reservaDAO;
        private readonly QuartoDAO _quartoDAO;
        private readonly ServicoDAO _servicoDAO;
       
        public ReservaController(ReservaDAO reservaDAO,
            QuartoDAO quartoDAO, PetDAO petDAO, ServicoDAO servicoDAO)
        {
            _reservaDAO = reservaDAO;
            _quartoDAO = quartoDAO;
            _petDAO = petDAO;
            _servicoDAO = servicoDAO;
        }

        [HttpPost]
        public IActionResult Cadastrar(Reserva r,
            int drpQuartos, int drpServicos)
        {
            ViewBag.Quartos =
                new SelectList(_quartoDAO.ListarTodos(),
                "IdQuarto", "NomeQuarto");

            ViewBag.Servicos =
                new SelectList(_servicoDAO.ListarTodos(),
                "IdServico", "NomeServico");




            if (ModelState.IsValid)
            {
                

                r.Quarto =
                    _quartoDAO.BuscarPorId(drpQuartos);

               

                if (_reservaDAO.Cadastrar(r))
                {
                    return RedirectToAction("Index");
                }
                ModelState.AddModelError
                    ("", "Esta reserva já existe!");
            }
            return View(r);
        }

        public IActionResult Index()
        {
            ViewBag.DataHora = DateTime.Now;
            return View(_reservaDAO.ListarTodos());
        }

        [HttpGet]
        public IActionResult Cadastrar()
        {
            ViewBag.Quartos =
                new SelectList(_quartoDAO.ListarTodos(),
                "IdQuarto", "NomeQuarto");

            ViewBag.Servicos =
                new SelectList(_servicoDAO.ListarTodos(),
                "IdServico", "NomeServico");

            return View();
        }


        public IActionResult Remover(int id)
        {
            _reservaDAO.Remover(id);
            return RedirectToAction("Index");
        }

        public IActionResult Alterar(int id)
        {
            return View
                (_reservaDAO.BuscarReservaPorId(id));
        }

        [HttpPost]
        public IActionResult Alterar(Reserva r)
        {
            _reservaDAO.Alterar(r);
            return RedirectToAction("Index");
        }


    }
}
