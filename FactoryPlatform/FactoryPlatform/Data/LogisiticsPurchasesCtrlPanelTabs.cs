using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class LogisiticsPurchasesCtrlPanelTabs
    {
        public int IdTabPanel { get; set; }
        public string DescripcionPanel { get; set; }
        public int? DepartamentoId { get; set; }
        public bool? Status { get; set; }
    }
}
