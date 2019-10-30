using Newtonsoft.Json;

namespace Mixogo.ClassesLibraries.Models
{
    public class Impuestos
    {
        [JsonProperty("cfdi:Traslados")]
        public Traslados Traslados { get; set; }
    }

}
