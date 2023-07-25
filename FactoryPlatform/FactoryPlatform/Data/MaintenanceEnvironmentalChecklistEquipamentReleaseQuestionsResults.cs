﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class MaintenanceEnvironmentalChecklistEquipamentReleaseQuestionsResults
    {
        public int IdRegistro { get; set; }
        public int PreguntaId { get; set; }
        public int ReleaseId { get; set; }
        public string Comentario { get; set; }
        public byte Resultado { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}