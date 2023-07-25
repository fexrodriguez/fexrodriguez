using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsCustomerVoiceModel
    {
        public List<DigitalDocumentsCustomerVoice> CustomerVoice { get; set; } = new List<DigitalDocumentsCustomerVoice>();
        public List<DigitalDocumentsCustomerVoice_Signatures> CustomerVoice_Signatures { get; set; } = new List<DigitalDocumentsCustomerVoice_Signatures>();
        public List<string> ftpFiles { get; set; } = new List<string>();
   
    }
}
