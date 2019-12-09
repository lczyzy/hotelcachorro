using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain
{
    public class Pessoa
    {

        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(3, ErrorMessage = "No mínimo 3 caracteres")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string Nome { get; set; }

        
        public Genero Genero { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public DateTime? DataNascimento { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        public string Rg { get; set; }

        [Display(Name = "Descrição:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(6, ErrorMessage = "No mínimo 6 caracteres")]
        public string Telefone { get; set; }





        public DateTime CriadoEm { get; set; }

        public Pessoa()
        {
            CriadoEm = DateTime.Now;
        }

    }
}
