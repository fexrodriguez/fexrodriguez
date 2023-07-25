using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class MaintenanceEquipmentMachineryMultiplant
    {
        public int IdMaquina { get; set; }
        public string NumeroMaquina { get; set; }
        public string DescripcionMaquina { get; set; }
        public DateTime? FechaInstalacion { get; set; }
        public int? FabricanteId { get; set; }
        public int? GrupoId { get; set; }
        public string Modelo { get; set; }
        public string NumeroSerie { get; set; }
        public string Ubicacion { get; set; }
        public int? EstacionId { get; set; }
        public DateTime? FechaUltimoServicio { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public bool? Critico { get; set; }
        public int PlantaUbicacionId { get; set; }
        public int PlantaId { get; set; }
        public int? Status { get; set; }
    }
}
