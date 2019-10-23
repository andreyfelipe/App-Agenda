using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace App_Agenda.Models
{
    public partial class Contatos
    {
        [Key]
        public int Id { get; set; }
        [Required]      
        public string Nome { get; set; }

        [Display(Name="E-mail")] [DataType(DataType.EmailAddress)]     
        public string Email { get; set; }

        [Display(Name="Telefone Fixo")] [DataType(DataType.PhoneNumber)]
        public string Telefonefixo { get; set; }

        [Display(Name="Telefone Celular")] [DisplayFormat(DataFormatString="(00)00000-0000")][DataType(DataType.PhoneNumber)]
         public string Telefonecelular { get; set; }


        [Display(Name="Empresa")] 
        public string Empresa { get; set; }


        [Display(Name="Cargo")]
        public string Cargo { get; set; }

        
        [Display(Name="Data Aniversário")][DisplayFormat(DataFormatString="DD/MM/AAAA")] [DataType(DataType.Date)]
         public DateTime Dataaniversario { get; set; }
    }
}
