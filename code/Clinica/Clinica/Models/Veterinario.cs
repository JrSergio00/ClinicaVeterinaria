using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Veterinario
    {
        public long VeterinarioId { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public string Crmv { get; set;  }
        public virtual ICollection<Consulta> Consultas { get; set; }
    }
}