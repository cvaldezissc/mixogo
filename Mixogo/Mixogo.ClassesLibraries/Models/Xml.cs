using Newtonsoft.Json;

namespace Mixogo.ClassesLibraries.Models
{
    public class Xml
    {
        [JsonProperty("version")]
        public string version { get; set; }

        [JsonProperty("encoding")]
        public string encoding { get; set; }
    }

}
