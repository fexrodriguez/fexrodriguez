using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DocsStructureTaskModel
    {
        public List<DocsStructureModel> DocsStructure { get; set; } = new List<DocsStructureModel>();
        public int? Id_Usuario { get; set; }
    }
}
