using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsToolListModel
    {
        public List<DigitalDocumentsToolList_Signatures> ToolList_Signatures { get; set; } = new List<DigitalDocumentsToolList_Signatures>();
        public List<DigitalDocumentsToolList> ToolListModel { get; set; } = new List<DigitalDocumentsToolList>();
    }
}
