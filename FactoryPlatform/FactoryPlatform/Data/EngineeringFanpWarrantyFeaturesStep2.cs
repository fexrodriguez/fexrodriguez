﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringFanpWarrantyFeaturesStep2
    {
        public int IdRegistro { get; set; }
        public int RegistroEntradaId { get; set; }
        public int CaracteristicaId { get; set; }
        public string Resultado { get; set; }
        public string Conclusion { get; set; }
        public bool? Status { get; set; }
    }
}
