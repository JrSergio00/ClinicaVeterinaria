using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Clinica.Models
{
    public class Consulta
    {
        public long ConsultaId { get; set; }
        public string Sintomas { get; set; }
        public DateTime Data_hora { get; set; }
        public Pet Pet{ get; set; }
        public long? VeterinarioId { get; set; }
        public long? PetId { get; set; }
        public Veterinario Veterinario { get; set; }
        public virtual ICollection<Pet> Pets { get; set; }
        public virtual ICollection<Veterinario> Veterinarios { get; set; }
    }
}