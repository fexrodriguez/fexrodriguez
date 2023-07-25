using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class MaintenanceEnvironmentalChecklistEquipamentReleaseQuestionsResultsAnexoB
    {
        public int IdRegistro { get; set; }
        public int PreguntaId { get; set; }
        public int ReleaseId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public string Regulaciones { get; set; }
        public string Autorizaciones { get; set; }
        public string Planes { get; set; }
        public string Infraestructura { get; set; }
    }
}
