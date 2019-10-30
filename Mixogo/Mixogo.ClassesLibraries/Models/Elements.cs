using Newtonsoft.Json;

namespace Mixogo.ClassesLibraries.Models
{

    public class CfdiImpuestos1
    {
        [JsonProperty("TotalImpuestosTrasladados")]
        public string TotalImpuestosTrasladados { get; set; }

        [JsonProperty("cfdi:Traslados")]
        public cfdiTraslados cfdiTraslados { get; set; }
    }

    public class cfdiTraslados
    {
        [JsonProperty("cfdi:Traslado")]
        public Traslado cfdiTraslado { get; set; }
    }

    public class cfdiTraslado
    {
        [JsonProperty("Impuesto")]
        public string Impuesto { get; set; }

        [JsonProperty("TipoFactor")]
        public string TipoFactor { get; set; }

        [JsonProperty("TasaOCuota")]
        public double TasaOCuota { get; set; }

        [JsonProperty("Importe")]
        public double Importe { get; set; }
    }

    public class CfdiComplemento
    {
        [JsonProperty("tfd:TimbreFiscalDigital")]
        public Timbrefiscaldigital TimbreFiscalDigital { get; set; }
    }

}
