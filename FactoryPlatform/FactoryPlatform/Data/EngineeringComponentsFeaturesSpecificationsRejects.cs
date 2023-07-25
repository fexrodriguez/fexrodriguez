﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringComponentsFeaturesSpecificationsRejects
    {
        public int IdRegistro { get; set; }
        public int EspecificacionId { get; set; }
        public int UsuarioRechazoId { get; set; }
        public DateTime FechaRechazo { get; set; }
        public string MotivoRechazo { get; set; }
        public bool? Status { get; set; }
    }
}
