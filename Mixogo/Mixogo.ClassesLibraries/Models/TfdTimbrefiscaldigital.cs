using Newtonsoft.Json;
using System;

namespace Mixogo.ClassesLibraries.Models
{
    public class Timbrefiscaldigital
    {
        [JsonProperty("xmlns:tfd")]
        public string xmlnstfd { get; set; }

        [JsonProperty("xsi:schemaLocation")]
        public string xsischemaLocation { get; set; }

        [JsonProperty("Version")]
        public string Version { get; set; }

        [JsonProperty("UUID")]
        public string UUID { get; set; }

        [JsonProperty("FechaTimbrado")]
        public DateTime FechaTimbrado { get; set; }

        [JsonProperty("RfcProvCertif")]
        public string RfcProvCertif { get; set; }

        [JsonProperty("SelloSAT")]
        public string SelloSAT { get; set; }

        [JsonProperty("SelloCFD")]
        public string SelloCFD { get; set; }

        [JsonProperty("NoCertificadoSAT")]
        public string NoCertificadoSAT { get; set; }
    }

}
