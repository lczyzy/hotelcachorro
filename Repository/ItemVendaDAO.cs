using Domain;
using HotelCachorro.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class ItemVendaDAO
    {
        private readonly Context _context;

        public ItemVendaDAO(Context context)
        {
            _context = context;
        }
        public ItemVenda BuscarPorId(int id)
        {
            return _context.ItensVenda.Find(id);
        }


        public bool Cadastrarxx(TempList tl)
        {
            ItemVenda itemAux = _context.ItensVenda.
                FirstOrDefault(x => x.Servico.IdServico == tl.Servico.IdServico);
            if (itemAux == null)
            {
                _context.ListTemp.Add(tl);
            }
            else
            {
                itemAux.Quantidade++;
            }
            _context.SaveChanges();
            return true;
        }

        public List<TempList> ValoresTempList()
        {
            return _context.ListTemp.ToList();
        }
            



        public bool Cadastrar(ItemVenda i)
        {
            ItemVenda itemAux = _context.ItensVenda.
                FirstOrDefault(x => x.Servico.IdServico == i.Servico.IdServico);
            if (itemAux == null)
            {
                _context.ItensVenda.Add(i);
            }
            else
            {
                itemAux.Quantidade++;
            }
            _context.SaveChanges();
            return true;
        }

        
        public List<ItemVenda> ListarTodos()
        {
            return _context.ItensVenda.ToList();
        }

        /*
        public List<ItemVenda> ListarItensPorCarrinhoId(string carrinhoId)
        {
            return _context.ItensVenda.
                Include(x => x.Produto.Categoria).
                Where(x => x.CarrinhoId.Equals(carrinhoId)).
                ToList();
        }

        public double RetornarTotalCarrinho(string carrinhoId)
        {
            return _context.ItensVenda.
                Where(x => x.CarrinhoId.Equals(carrinhoId)).
                Sum(x => x.Quantidade * x.Preco);
        }*/

        public void RemoverTudoTemp()
        {
            _context.ListTemp.RemoveRange();
        }


        public bool RemoverVendaPorId(int reserva)
        {

            IEnumerable<ItemVenda> list = _context.ItensVenda.Where(c => c.Reserva.IdReserva == reserva).ToList();
            _context.ItensVenda.RemoveRange(list);
            _context.SaveChanges();
            return true;

        }

        public void RemoverItensVenda(int id)
        {
            _context.ItensVenda.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }


        public void Remover(int id)
        {
            _context.ItensVenda.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
        public void Alterar(ItemVenda i)
        {
            _context.ItensVenda.Update(i);
            _context.SaveChanges();
        }

        public void AumentarQuantidade(int id)
        {
            ItemVenda i = BuscarPorId(id);
            i.Quantidade++;
            Alterar(i);
        }

        public void DiminuirQuantidade(int id)
        {
            ItemVenda i = BuscarPorId(id);
            if (i.Quantidade > 1)
            {
                i.Quantidade--;
                Alterar(i);
            }
        }
    }
}
