using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mixogo.ClassesLibraries.Models
{
    public class Comprobante
    {
        public string xsi { get; set; }
        public string SchemaLocation { get; set; }
        public string Version { get; set; }
        public string Serie { get; set; }
        public long Folio { get; set; }
        public DateTime Fecha { get; set; }
        public string Sello { get; set; }
        public int FormaPago { get; set; }
        public string NoCertificado { get; set; }
        public string Certificado { get; set; }
        public string CondicionesDePago { get; set; }
        public double SubTotal { get; set; }
        public string Moneda { get; set; }
        public double Total { get; set; }
        public string TipoDeComprobante { get; set; }
        public string MetodoPago { get; set; }
        public int LugarExpedicion { get; set; }
        public Emisor Emisor { get; set; }
        public Receptor Receptor { get; set; }
        public List<Concepto> Conceptos { get; set; }
        public Impuestos Impuestos { get; set; }
        public Complemento Complemento { get; set; }







    }
}
