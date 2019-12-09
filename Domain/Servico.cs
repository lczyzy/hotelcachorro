using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{

    [Table("Servicos")]
    public  class Servico
    {
        [Key]
        public int IdServico { get; set; }


        [Display(Name = "Descrição:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(3, ErrorMessage = "No mínimo 3 caracteres")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string NomeServico { get; set; }

        [Required(ErrorMessage = "Campo obrigatório!")]
        [Range(1, 10000, ErrorMessage = "Quantidade apenas entre 1 e 1000!")]
        [Display(Name = "Preço:")]
        public double PrecoServico { get; set; }


        public Categoria Categoria { get; set; }

    }
}
