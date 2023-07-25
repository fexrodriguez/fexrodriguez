using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DocumentTrainingTaskModel
    {
        public List<DocumentTrainingModel> DocumentTrainingModel { get; set; }
        public List<DocumentTrainingStep1> DocumentTrainingStep1 { get; set; }
    }
}
