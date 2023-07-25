﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringToolingTemplateDetailsExtra
    {
        public int IdRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int CheckListId { get; set; }
        public int DepartamentoId { get; set; }
        public int OperacionId { get; set; }
        public string Actividad { get; set; }
        public int ResponsableId { get; set; }
    }
}
