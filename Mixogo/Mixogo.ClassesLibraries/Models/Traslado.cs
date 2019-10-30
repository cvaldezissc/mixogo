using Newtonsoft.Json;

namespace Mixogo.ClassesLibraries.Models
{
    public class Traslado
    {
        [JsonProperty("Base")]
        public string Base { get; set; }

        [JsonProperty("Impuesto")]
        public double Impuesto { get; set; }

        [JsonProperty("TipoFactor")]
        public string TipoFactor { get; set; }

        [JsonProperty("TasaOCuota")]
        public double TasaOCuota { get; set; }

        [JsonProperty("Importe")]
        public double Importe { get; set; }
    }

}
