using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsFeasibilityModel
    {
        public List<DigitalDocumentsFeasibility_Signatures> DigitalDocumentsFeasibility_Signatures { get; set; } = new List<DigitalDocumentsFeasibility_Signatures>();
        public List<DigitalDocumentsFeasibility> DigitalDocumentsFeasibility { get; set; } = new List<DigitalDocumentsFeasibility>();
    }
}
