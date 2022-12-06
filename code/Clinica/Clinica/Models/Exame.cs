using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Exame
    {
        public long ExameId { get; set; }
        public string Descricao { get; set; }
        public Consulta Consulta { get; set; }
        public long? ConsultaId { get; set; }
        public virtual ICollection<Exame> Exames{ get; set; }
    }
}