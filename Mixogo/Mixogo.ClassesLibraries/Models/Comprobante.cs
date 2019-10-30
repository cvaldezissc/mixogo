using Newtonsoft.Json;
using System;

namespace Mixogo.ClassesLibraries.Models
{
    public class Comprobante
    {
        [JsonProperty("xmlns:cfdi")]
        public string cfdi { get; set; }

        [JsonProperty("xmlns:add")]
        public string add { get; set; }

        [JsonProperty("xmlns:detallista")]
        public string detallista { get; set; }

        [JsonProperty("xmlns:divisas")]
        public string divisas { get; set; }

        [JsonProperty("xmlns:donat")]
        public string donat { get; set; }

        [JsonProperty("xmlns:ecbc")]
        public string ecbc { get; set; }

        [JsonProperty("xmlns:ecc")]
        public string ecc { get; set; }

        [JsonProperty("xmlns:iedu")]
        public string iedu { get; set; }

        [JsonProperty("xmlns:implocal")]
        public string implocal { get; set; }

        [JsonProperty("xmlns:ine")]
        public string ine { get; set; }

        [JsonProperty("xmlns:leyendasFisc")]
        public string leyendasFisc { get; set; }

        [JsonProperty("xmlns:nomina12")]
        public string nomina12 { get; set; }

        [JsonProperty("xmlns:pfic")]
        public string pfic { get; set; }

        [JsonProperty("xmlns:psgcfdsp")]
        public string psgcfdsp { get; set; }

        [JsonProperty("xmlns:psgecfd")]
        public string psgecfd { get; set; }

        [JsonProperty("xmlns:terceros")]
        public string terceros { get; set; }

        [JsonProperty("xmlns:tpe")]
        public string tpe { get; set; }

        [JsonProperty("xmlns:ventavehiculos")]
        public string ventavehiculos { get; set; }

        [JsonProperty("xmlns:xsi")]
        public string xsi { get; set; }

        [JsonProperty("xsi:schemaLocation")]
        public string schemaLocation { get; set; }

        [JsonProperty("Version")]
        public string Version { get; set; }

        [JsonProperty("Serie")]
        public string Serie { get; set; }

        [JsonProperty("Folio")]
        public string Folio { get; set; }

        [JsonProperty("Fecha")]
        public DateTime Fecha { get; set; }

        [JsonProperty("Sello")]
        public string Sello { get; set; }

        [JsonProperty("FormaPago")]
        public string FormaPago { get; set; }

        [JsonProperty("NoCertificado")]
        public string NoCertificado { get; set; }

        [JsonProperty("Certificado")]
        public string Certificado { get; set; }

        [JsonProperty("SubTotal")]
        public double SubTotal { get; set; }

        [JsonProperty("Descuento")]
        public double Descuento { get; set; }

        [JsonProperty("Moneda")]
        public string Moneda { get; set; }

        [JsonProperty("Total")]
        public double Total { get; set; }

        [JsonProperty("TipoDeComprobante")]
        public string TipoDeComprobante { get; set; }

        [JsonProperty("MetodoPago")]
        public string MetodoPago { get; set; }

        [JsonProperty("LugarExpedicion")]
        public string LugarExpedicion { get; set; }

        [JsonProperty("cfdi:Emisor")]
        public Emisor Emisor { get; set; }

        [JsonProperty("cfdi:Receptor")]
        public Receptor Receptor { get; set; }


        [JsonProperty("cfdi:Conceptos")]
        public CfdiConceptos Conceptos { get; set; }

        [JsonProperty("cfdi:Impuestos")]
        public CfdiImpuestos1 Impuestos { get; set; }

        [JsonProperty("cfdi:Complemento")]
        public CfdiComplemento Complemento { get; set; }
    }

}
