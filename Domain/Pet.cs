using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
   
        [Table("Pet")]
        public class Pet
        {
            [Key]
            public int IdPet { get; set; }


        [Display(Name = "Nome:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(3, ErrorMessage = "No mínimo 5 caracteres")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string Nome { get; set; }

            public Cliente cliente { get; set; }

            public Genero Genero { get; set; }



        [Display(Name = "Raça:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(5, ErrorMessage = "No mínimo 5 caracteres")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string Raca { get; set; }


        [Display(Name = "Castragem:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(3, ErrorMessage = "No mínimo 3 caracteres")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string Castragem { get; set; }


        [Display(Name = "Pelagem:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(3, ErrorMessage = "No mínimo 3 caracteres")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string Pelagem { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        [Range(0, 30, ErrorMessage = "Quantidade apenas entre 0 e 30!")]
        [Display(Name = "Idade:")]
        public int Idade { get; set; }


        [Display(Name = "Porte:")]
        [Required(ErrorMessage = "Campo obrigatório!")]
        [MinLength(3, ErrorMessage = "No mínimo 3 caracteres")]
        [MaxLength(100, ErrorMessage = "No máximo 100 caracteres")]
        public string Porte { get; set; }


        [Required(ErrorMessage = "Campo obrigatório!")]
        [Range(1, 200, ErrorMessage = "Quantidade apenas entre 1 e 200!")]
        [Display(Name = "Peso:")]  
        public double Peso { get; set; }

            public string Imagem { get; set; }

         }
}
