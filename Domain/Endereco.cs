using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Domain
{
    [Table("Enderecos")]
    public class Endereco
    {

        [Key]
        public int EnderecoId { get; set; }

        public string Bairro { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public string End { get; set; }
        public string Uf { get; set; }





        /*
        [Key]
        public int EnderecoId { get; set; }
        [Display(Name = "CEP:")]
        public string Cep { get; set; }
        [Display(Name = "Rua:")]
        public string Logradouro { get; set; }
        [Display(Name = "Bairro:")]
        public string Bairro { get; set; }
        [Display(Name = "Cidade:")]
        public string Localidade { get; set; }
        [Display(Name = "Estado:")]
        public string Uf { get; set; }
        public DateTime CriadoEm { get; set; }
        */
    }
}
