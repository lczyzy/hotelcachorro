using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Domain
{

    [Table("Reservas")]
    public class Reserva
    {

        [Key]
        public int IdReserva { get; set; }
        public Pet Pet { get; set; }
        public Quarto Quarto { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public double ValorTotal { get; set; }
        public List<ItemVenda> ItensVendidos { get; set; }

    }
}
