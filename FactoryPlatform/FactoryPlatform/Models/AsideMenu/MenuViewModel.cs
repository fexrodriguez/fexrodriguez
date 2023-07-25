using System.Collections.Generic;

namespace FactoryPlatform.Models
{
    public class MenuViewModel
    {
        public List<spFPAPP_Sys_menus> spFPAPP_Sys_menus { get; set; } = new List<spFPAPP_Sys_menus>();
        public List<spFPAPP_Sys_apps> spFPAPP_Sys_apps { get; set; } = new List<spFPAPP_Sys_apps>();
    }
}
