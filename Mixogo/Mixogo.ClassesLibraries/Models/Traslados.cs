using Newtonsoft.Json;

namespace Mixogo.ClassesLibraries.Models
{
    public class Traslados
    {
        [JsonProperty("cfdi:Traslado")]
        public Traslado Traslado { get; set; }
    }

}
