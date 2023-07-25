using FactoryPlatform.Areas.ServiceNow.Models;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsReleaseModel
    {
        public List<DigitalDocumentsReleaseInfoDocument> ReleaseInfoDocument { get; set; } = new List<DigitalDocumentsReleaseInfoDocument>();
        public List<DigitalDocumentsReleaseQuestions> ReleaseQuestions { get; set; } = new List<DigitalDocumentsReleaseQuestions>();
        public List<DigitalDocumentsReleaseAnexB> ReleaseQAnexoB { get; set; } = new List<DigitalDocumentsReleaseAnexB>();
    }
}
