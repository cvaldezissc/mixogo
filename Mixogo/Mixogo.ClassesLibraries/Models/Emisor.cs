using Newtonsoft.Json;

namespace Mixogo.ClassesLibraries.Models
{
    public class Emisor
    {
        [JsonProperty("Rfc")]
        public string Rfc { get; set; }

        [JsonProperty("Nombre")]
        public string Nombre { get; set; }

        [JsonProperty("RegimenFiscal")]
        public string RegimenFiscal { get; set; }
    }

}
