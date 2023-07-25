using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesTrainingBusinessUnit
    {
        public int IdUnidadNegocio { get; set; }
        public string Unidad { get; set; }
        public string Comentarios { get; set; }
        public int? ResponsableId { get; set; }
        public int? CoordinadorIngenieriaId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int? PlantaId { get; set; }
        public bool? Status { get; set; }
    }
}
