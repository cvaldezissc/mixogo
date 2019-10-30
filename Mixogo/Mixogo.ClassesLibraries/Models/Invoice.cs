using Newtonsoft.Json;

namespace Mixogo.ClassesLibraries.Models
{
    public class Invoice
    {
        [JsonProperty("xml")]
        public Xml xml { get; set; }

        [JsonProperty("cfdi:Comprobante")]
        public Comprobante Comprobante { get; set; }
    }

}
