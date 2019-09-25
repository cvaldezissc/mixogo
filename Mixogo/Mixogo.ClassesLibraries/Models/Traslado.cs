using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mixogo.ClassesLibraries.Models
{
    public class Traslado
    {
        public double Base { get; set; }
        public string Impuesto { get; set; }
        public string TipoFactor { get; set; }
        public double TasaOCuota { get; set; }
        public double Importe { get; set; }

    }
}
