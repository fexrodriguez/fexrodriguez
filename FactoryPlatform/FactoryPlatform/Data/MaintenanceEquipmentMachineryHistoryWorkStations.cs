using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class MaintenanceEquipmentMachineryHistoryWorkStations
    {
        public int IdRegistro { get; set; }
        public int MaquinaId { get; set; }
        public int EstacionAnteriorId { get; set; }
        public int EstacionNuevaId { get; set; }
        public int? PlantaAnteriorId { get; set; }
        public int? PlantaNuevaId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public string Comentarios { get; set; }
        public bool? Status { get; set; }
    }
}
