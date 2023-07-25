using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class FinalSignatureTaskModel
    {
        public List<FinalSignatureModel> FinalSignature { get; set; } = new List<FinalSignatureModel>();
        public int? Id_Usuario { get; set; }
    }
}
