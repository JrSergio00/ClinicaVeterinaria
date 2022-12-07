using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Pet
    {
        public long PetId { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
        public Especie Especie{ get; set; }
        public long? EspecieId { get; set; }
        public virtual ICollection<Consulta> Consultas { get; set; }

    }
}