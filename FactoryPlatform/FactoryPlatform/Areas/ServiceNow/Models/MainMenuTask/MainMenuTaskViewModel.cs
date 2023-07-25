using FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.AnpControl;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class MainMenuTaskViewModel
    {
        public DocsEditionTaskModel DocsEditionTaskModel { get; set; }
        public PreApprovalTaskModel PreApprovalTaskModel { get; set; }
        public FinalSignatureTaskModel FinalSignatureTaskModel { get; set; }
        public DocumentTrainingTaskModel DocumentTrainingTaskModel { get; set; } 
        public ITWorkOrderTaskModel ITWorkOrderTaskModel { get; set; }
        public DocsStructureTaskModel DocsStructureTaskModel  { get; set; }
        public TMCorrectiveActionViewModel TMCorrectiveActionViewModel { get; set; }
        public TMAnpControlViewModel TMAnpControlViewModel { get; internal set; }
    }
}
