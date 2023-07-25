using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityModelFeatures
    {
        public int IdRegistro { get; set; }
        public string Modelo { get; set; }
        public int Estacion { get; set; }
        public string Titulo { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioId { get; set; }
        public int Orden { get; set; }
        public int PlantaId { get; set; }
        public int? FotoCatPicId { get; set; }
        public DateTime? FechaActualizadoOrden { get; set; }
    }
}
