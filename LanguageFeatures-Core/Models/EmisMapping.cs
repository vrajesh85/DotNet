using System.Collections.Generic;

namespace LanguageFeatures.Models
{
    public class EmisMapping
    {
        public string Version { get; set; }
        public string UpdatedBy { get; set; }
        public string DataDate { get; set;}
        public string LastModified { get; set; }
        public List<Mapping> Mappings { get; set; }
    }

    public class Mapping
    {
        public string EmisCode { get; set; }
        public string SnomedCode { get; set; }
    }
}
