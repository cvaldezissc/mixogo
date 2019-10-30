using Newtonsoft.Json;

namespace Mixogo.ClassesLibraries.Models
{
    public class Receptor
    {
        [JsonProperty("Rfc")]
        public string Rfc { get; set; }

        [JsonProperty("Nombre")]
        public string Nombre { get; set; }

        [JsonProperty("UsoCFDI")]
        public string UsoCFDI { get; set; }
    }

}
