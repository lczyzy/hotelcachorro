﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class ItemVenda
    {
        public ItemVenda()
        {
            CriadoEm = DateTime.Now;
            Produto = new Produto();
        }
        [Key]
        public int ItemVendaId { get; set; }
        public Produto Produto { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public DateTime CriadoEm { get; set; }
        public string CarrinhoId { get; set; }
    }
}
