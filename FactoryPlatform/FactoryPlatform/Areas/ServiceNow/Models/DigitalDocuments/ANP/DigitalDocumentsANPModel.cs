using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsANPModel
    {
        public List<DigitalDocumentsANP> DigitalDocumentsANP { get; set; } = new List<DigitalDocumentsANP>();
        public List<DigitalDocumentsANP_Signatures> ANP_Signatures { get; set; } = new List<DigitalDocumentsANP_Signatures>();
        public List<DigitalDocumentsANP_Desviatios> ANP_Desviatios { get; set; } = new List<DigitalDocumentsANP_Desviatios>();
        public List<string> Mediciones { get; set; }

        public List<string> DatosEntrada { get; set; }
        public List<string> Conclusiones { get; set; }
    }
}
