using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Pessoa
    {

        [Display(Name = "Nome:")]   
        [MinLength(3, ErrorMessage = "No mínimo 3 caracteres")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string Nome { get; set; }

        
        public Genero Genero { get; set; }

        public DateTime? DataNascimento { get; set; }

        
        public string Cpf { get; set; }

        
        public string Rg { get; set; }

        [Display(Name = "Telefone:")]  
        [MinLength(6, ErrorMessage = "No mínimo 6 caracteres")]
        public string Telefone { get; set; }





        public DateTime CriadoEm { get; set; }

        public Pessoa()
        {
            CriadoEm = DateTime.Now;
        }

    }
}
