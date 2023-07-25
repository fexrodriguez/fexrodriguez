using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class MaintenanceEquipmentMachineryEvidenceReplace
    {
        public int IdRegistro { get; set; }
        public string Maquina { get; set; }
        public int Proceso { get; set; }
        public DateTime Fecha { get; set; }
        public string NombreArchivo { get; set; }
        public int Planta { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
