using System;
using System.Collections.Generic;

namespace App_Agenda.Models
{
    public partial class Contatos
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefonefixo { get; set; }
        public string Telefonecelular { get; set; }
        public string Empresa { get; set; }
        public string Cargo { get; set; }
        public DateTime? Dataaniversario { get; set; }
    }
}
