using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mixogo.ClassesLibraries.Models
{
    public class Impuestos
    {
        public double TotalImpuestosTrasladados { get; set; }
        public List<Traslado> Traslados { get; set; }

    }
}
