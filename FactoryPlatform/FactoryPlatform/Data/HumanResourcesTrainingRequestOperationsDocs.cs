﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesTrainingRequestOperationsDocs
    {
        public int IdRegistro { get; set; }
        public int SolicitudId { get; set; }
        public int DocumentoId { get; set; }
        public bool? Aprobado { get; set; }
        public DateTime? FechaAprobado { get; set; }
        public bool? Status { get; set; }
    }
}