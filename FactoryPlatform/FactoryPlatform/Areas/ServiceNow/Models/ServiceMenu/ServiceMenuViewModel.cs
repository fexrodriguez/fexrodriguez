using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class ServiceMenuViewModel
    {
        public DocViewerViewModel DocViewerViewModel { get; set; }
        public EngWorkOrdersModel EngWorkOrdersModel { get; set; }
        public ItWorkOrdersModel ItWorkOrdersModel { get; set; }
        public MTCEWorkOrdersModel MTCEWorkOrdersModel { get; set; }
        public QltyWorkOrdersModel QltyWorkOrdersModel { get; set; }
        public HRWorkOrdersModel HRWorkOrdersModel { get; set; }
        public List<SelectListItem> CaptureNewItem { get; set; }
        public CorrectiveActionViewModel CorrectiveActionViewModel { get; set; }






    }
}
