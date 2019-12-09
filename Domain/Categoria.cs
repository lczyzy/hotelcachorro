using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Categorias")]
    public class Categoria
    {
        public Categoria() { CriadoEm = DateTime.Now; }
        [Key]
        public int CategoriaId { get; set; }

        [Display(Name = "Descrição da categoria:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(3, ErrorMessage = "No mínimo 5 caracteres")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string Nome { get; set; }



        public DateTime CriadoEm { get; set; }
    }
}
