using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityComponentsRecovery
    {
        public int IdComponente { get; set; }
        public string Componente { get; set; }
        public string Descripcion { get; set; }
        public bool? Status { get; set; }
    }
}
