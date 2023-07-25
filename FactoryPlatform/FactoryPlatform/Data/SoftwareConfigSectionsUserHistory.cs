﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class SoftwareConfigSectionsUserHistory
    {
        public int IdRegistro { get; set; }
        public int PageId { get; set; }
        public string Departamento { get; set; }
        public string Aplicacion { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
