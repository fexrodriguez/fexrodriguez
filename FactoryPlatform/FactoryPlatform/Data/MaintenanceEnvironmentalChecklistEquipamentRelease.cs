using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class MaintenanceEnvironmentalChecklistEquipamentRelease
    {
        public int IdRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public byte Status { get; set; }
        public string Idmejora { get; set; }
        public int PlantaId { get; set; }
        public int EvaluationId { get; set; }
        public int TypeId { get; set; }
        public string Descripcion { get; set; }
        public int? ResponsableId { get; set; }
        public int? TypeEngId { get; set; }
        public int? ProyectoId { get; set; }
    }
}
