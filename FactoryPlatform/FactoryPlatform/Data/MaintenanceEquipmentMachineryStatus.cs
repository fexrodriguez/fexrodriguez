﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class MaintenanceEquipmentMachineryStatus
    {
        public int IdStatus { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistro { get; set; }
        public string Comentarios { get; set; }
        public int? PlantaId { get; set; }
        public bool? Status { get; set; }
    }
}
