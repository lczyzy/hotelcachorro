using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HotelCachorro.Model;
using Repository;
using Domain;
using System.Dynamic;

namespace EcommerceAngelo.Controllers
{
    public class ReservaController : Controller
    {
        
        private readonly PetDAO _petDAO;
        private readonly ReservaDAO _reservaDAO;
        private readonly QuartoDAO _quartoDAO;
        private readonly ServicoDAO _servicoDAO;
        private readonly ClienteDAO _clienteDAO;
        private readonly ItemVendaDAO _itemVendaDAO;
       

        public ReservaController(ReservaDAO reservaDAO,
            QuartoDAO quartoDAO, PetDAO petDAO, ServicoDAO servicoDAO, ClienteDAO clienteDAO, ItemVendaDAO itemVendaDAO)
        {
            _reservaDAO = reservaDAO;
            _quartoDAO = quartoDAO;
            _petDAO = petDAO;
            _servicoDAO = servicoDAO;
            _clienteDAO = clienteDAO;
            _itemVendaDAO = itemVendaDAO;
        }

        private ItemVenda ivvv = new ItemVenda();

        private List<TempList> tempList;

        private List<ItemVenda> itensVendaLista = new List<ItemVenda>();

        private double total = 0;
        

        public IActionResult AddServico(int id, int drpServicos)
        {

            TempList tl = new TempList();


            ViewBag.Servicos = new SelectList
                (_servicoDAO.ListarTodos(), "IdServico",
                "NomeServico");


            Servico s = new Servico();

            s = _servicoDAO.BuscarPorId(drpServicos);

            Reserva r = new Reserva();

            //Adicionar os produtos dentro do carrinho
            ItemVenda i = new ItemVenda
            {
                Servico = s,
                Quantidade = 1,
                Preco = s.PrecoServico,
                Reserva = r,
                Nome = s.NomeServico
            };


            tl.Nome = s.NomeServico;
            tl.Preco = s.PrecoServico;
            tl.Quantidade = 1;
            tl.Servico = s;



            //Gravar o objeto na tabela
            _itemVendaDAO.Cadastrarxx(tl);
            //_itemVendaDAO.Cadastrar(i);

            itensVendaLista.Add(i);

            

            return RedirectToAction("Cadastrar");
        }



        
        public IActionResult Cadastrar(Reserva r,
            int drpQuartos, int drpServicos, int drpPets)
        {
            ViewBag.Quartos =
                new SelectList(_quartoDAO.ListarTodos(),
                "IdQuarto", "NomeQuarto");


            
            ViewBag.Servicos =
                new SelectList(_servicoDAO.ListarTodos(),
                "IdServico", "NomeServico");

            ViewBag.Pets =
                new SelectList(_petDAO.ListarTodos(),
                "IdPet", "Nome");

           

            if (ModelState.IsValid)
            {
               

                r.Quarto =
                    _quartoDAO.BuscarPorId(drpQuartos);

                r.Pet = _petDAO.BuscarPorId(drpPets);



               

                

               

                
                tempList = _itemVendaDAO.ValoresTempList();


               
                foreach (var itens in tempList)
                {
                    //ivvv.Nome = itens.Nome;
                    //ivvv.Preco = itens.Preco;
                    //ivvv.Quantidade = itens.Quantidade;
                    //ivvv.Servico = itens.Servico;
                    //ivvv.Reserva = r;

                    ItemVenda i = new ItemVenda
                    {
                        Servico = itens.Servico,
                        Quantidade = 1,
                        Preco = itens.Preco,
                        Reserva = r,
                        Nome = itens.Nome
                    };

                    _itemVendaDAO.Cadastrar(i);

                    itensVendaLista.Add(i);

                    //add total

                    total += itens.Preco;

                    //itensVendaLista.Add(ivvv);
                }


                //pegar datas para obter quantidade dias
 
                TimeSpan Dias = r.DataSaida.Subtract(r.DataEntrada);
                int totalDias = Convert.ToInt32(Dias.Days);

                //calcular preco quarto +
                //Quarto qota = _quartoDAO.ValorQuarto(_quartoDAO.BuscarPorId());
              
                double precoestadia = totalDias * r.Quarto.PrecoQuarto;
                total += precoestadia;


                r.ItensVendidos = itensVendaLista;
                r.ValorTotal = total;

           

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

            ViewBag.Pets =
                 new SelectList(_petDAO.ListarTodos(),
                 "IdPet", "Nome");


            return View();
        }


        public IActionResult Remover(int id)
        {
            _itemVendaDAO.RemoverVendaPorId(id);
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


        [HttpPost]
        public IActionResult BuscarClientePorPet(Reserva r)
        {
            //Cliente c = new Cliente();
            var c = _clienteDAO.BuscarClientePorCPF(r.Pet.cliente);


            if (c != null)
            {
                ViewBag.Pets = new SelectList(_petDAO.ListarPetPorCliente(c.IdCliente),
                "IdPet", "Nome");

                return RedirectToAction(nameof(Cadastrar));

            }



            return RedirectToAction("Index");
        }

    }
}
