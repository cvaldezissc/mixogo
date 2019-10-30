using Newtonsoft.Json;

namespace Mixogo.ClassesLibraries.Models
{
    public class Concepto
    {
        [JsonProperty("ClaveProdServ")]
        public string ClaveProdServ { get; set; }

        [JsonProperty("Cantidad")]
        public int Cantidad { get; set; }

        [JsonProperty("ClaveUnidad")]
        public string ClaveUnidad { get; set; }

        [JsonProperty("Descripcion")]
        public string Descripcion { get; set; }

        [JsonProperty("ValorUnitario")]
        public double ValorUnitario { get; set; }

        [JsonProperty("Importe")]
        public double Importe { get; set; }

        [JsonProperty("Descuento")]
        public double Descuento { get; set; }

        [JsonProperty("cfdi:Impuestos")]
        public Impuestos Impuestos { get; set; }
    }

}
