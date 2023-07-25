using FactoryPlatform.Data;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class SystemHostViewModel
    {
        public List<MainMenuModel> MainMenu { get; set; } = new List<MainMenuModel>();
        public List<ServicesMenuModel> ServicesMenu { get; set; } = new List<ServicesMenuModel>();
        
        //Models for each tags
        public ServiceMenuViewModel ServiceMenuViewModel { get; set; }
        public MainMenuTaskViewModel MainMenuTaskViewModel { get; set; }
    }
}
