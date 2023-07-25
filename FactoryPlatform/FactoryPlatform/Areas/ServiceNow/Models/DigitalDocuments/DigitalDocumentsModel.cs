using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsModel
    {
        public List<DigitalDocumentsDesviationModel> DigitalDocumentsDesviationModel { get; set; } = new List<DigitalDocumentsDesviationModel>();
        public List<DigitalDocumentAMEF_Model> DigitalDocumentAMEF_Model { get; set; } = new List<DigitalDocumentAMEF_Model>();
        public DigitalDocumentsOpenIssuesModel DigitalDocumentsOpenIssuesModel { get; set; } = new DigitalDocumentsOpenIssuesModel();
        public DigitalDocumentsReleaseModel DigitalDocumentsReleaseModel { get; set; } = new DigitalDocumentsReleaseModel();
        public DigitalDocumentsFeasibilityModel DigitalDocumentsFeasibilityModel { get; set; } = new DigitalDocumentsFeasibilityModel();
        public DigitalDocumentsToolListModel DigitalDocumentsToolListModel { get; set; } = new DigitalDocumentsToolListModel();
        public DigitalDocumentsCustomerVoiceModel DigitalDocumentsCustomerVoiceModel { get; set; } = new DigitalDocumentsCustomerVoiceModel();
        public DigitalDocumentsANPModel DigitalDocumentsANPModel { get; set; } = new DigitalDocumentsANPModel();
    }
}
