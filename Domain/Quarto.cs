using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Quartos")]
    public class Quarto
    {
        [Key]
        public int IdQuarto { get; set; }


        [Display(Name = "Nome quarto:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(3, ErrorMessage = "No mínimo 3 caracteres")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string NomeQuarto { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        [Range(5, 10000, ErrorMessage = "Quantidade apenas entre 1 e 10000!")]
        [Display(Name = "Preço quarto:")]
        public double PrecoQuarto { get; set; }

        [Range(5, 10000, ErrorMessage = "Quantidade precisa ser maior que 5!")]
        public string InfoAdicional { get; set; }
    }
}
