using Newtonsoft.Json;

namespace Mixogo.ClassesLibraries.Models
{
    public class CfdiConceptos
    {
        [JsonProperty("cfdi:Concepto")]
        public Concepto[] Conceptos { get; set; }
    }

}
