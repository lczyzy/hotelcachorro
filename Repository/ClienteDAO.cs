﻿using Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class ClienteDAO : IRepository<Cliente>
    {
        private readonly Context _context;
        public ClienteDAO(Context context)
        {
            _context = context;
        }
        public bool Cadastrar(Cliente c)
        {

                if (BuscarClientePorCpf(c.Cpf) == null)
                {
                    _context.Clientes.Add(c);
                    _context.SaveChanges();
                    return true;
                }

            return false;
        }
        public Cliente BuscarClientePorNome(Cliente c)
        {
            return _context.Clientes.FirstOrDefault
                (x => x.Nome.Equals(c.Nome));
        }
        public List<Cliente> ListarTodos()
        {
            return _context.Clientes.ToList();
        }
        public Cliente BuscarPorId(int id)
        {
            return _context.Clientes.Find(id);
        }
        public void Remover(int id)
        {
            _context.Clientes.Remove(BuscarPorId(id));
            _context.SaveChanges();
        }
        public void Alterar(Cliente c)
        {
            _context.Clientes.Update(c);
            _context.SaveChanges();
        }

        public List<Cliente> ListarPorCategoria(int? id)
        {
            return _context.Clientes.Include(x => x.Genero).
                Where(x => x.Genero.GeneroId == id).
                ToList();
        }


        public Cliente BuscarClientePorCpf(string cpf)
        {
            return _context.Clientes.FirstOrDefault(x => x.Cpf.Equals(cpf));
        }

        public Cliente BuscarClientePorCPF(Cliente c)
        {
            return _context.Clientes.FirstOrDefault(x => x.Cpf.Equals(c.Cpf));
        }


        public bool ValidarCpf(string cpf)
        {
            #region Validação Simples
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
            {
                return false;
            }
            switch (cpf)
            {
                case "00000000000":
                    return false;
                case "11111111111":
                    return false;
                case "22222222222":
                    return false;
                case "33333333333":
                    return false;
                case "44444444444":
                    return false;
                case "55555555555":
                    return false;
                case "66666666666":
                    return false;
                case "77777777777":
                    return false;
                case "88888888888":
                    return false;
                case "99999999999":
                    return false;
            }
            #endregion

            #region Variaveis
            int peso = 10;
            int soma = 0;
            int resto;
            int digito1, digito2;
            #endregion

            #region Digito 1
            for (int i = 0; i < 9; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString())
                    * peso;
                peso--;
            }
            resto = soma % 11;
            if (resto < 2)
            {
                digito1 = 0;
            }
            else
            {
                digito1 = 11 - resto;
            }
            #endregion

            #region Digito 2
            soma = 0;
            peso = 11;
            for (int i = 0; i < 10; i++)
            {
                soma += Convert.ToInt32(cpf[i].ToString())
                    * peso;
                peso--;
            }
            resto = soma % 11;
            if (resto < 2)
            {
                digito2 = 0;
            }
            else
            {
                digito2 = 11 - resto;
            }
            #endregion

            #region Comparacao
            if (digito1 == Convert.ToUInt32(cpf[9].ToString()) &&
                digito2 == Convert.ToUInt32(cpf[10].ToString()))
            {
                return true;
            }
            return false;
            #endregion
        }

    }
}
