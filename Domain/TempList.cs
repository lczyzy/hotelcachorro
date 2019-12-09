using HotelCachorro.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{

    [Table("TemList")]
    public class TempList
    {

        [Key]
        public int TempId { get; set; }


        public Servico Servico { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }

    }
}
