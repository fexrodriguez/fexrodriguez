using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class PreApprovalTaskModel
    {
        public List<PreApprovalModel> PreApproval { get; set; } = new List<PreApprovalModel>();
        public int? Id_Usuario { get; set; }

    }
}
