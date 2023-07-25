using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsOpenIssuesModel
    {
        public List<DigitalDocumentsOpenIssues> DigitalDocumentsOpenIssues { get; set; } = new List<DigitalDocumentsOpenIssues>();
        public List<DigitalDocumentsOpenIssues_Hallazgo> DigitalDocumentsOpenIssues_Hallazgo { get; set; } = new List<DigitalDocumentsOpenIssues_Hallazgo>();
    }
}
