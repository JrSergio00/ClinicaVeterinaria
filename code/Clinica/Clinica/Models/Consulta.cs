﻿using System;
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
    }
}