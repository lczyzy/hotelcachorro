using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Clientes")]
    public class Cliente : Pessoa
    {
        [Key]
        public int IdCliente { get; set; }

        [Display(Name = "Sobrenome:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(3, ErrorMessage = "No mínimo 3 caracteres")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string Sobrenome { get; set; }

        
        public Endereco Endereco { get; set;}

        public string TelefoneContato { get; set; }

    }

}

