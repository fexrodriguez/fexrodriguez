﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityAuditsWarrantyActions
    {
        public int IdAccion { get; set; }
        public string Accion { get; set; }
        public int? FamiliaId { get; set; }
        public int? EstacionId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public bool? Status { get; set; }
    }
}