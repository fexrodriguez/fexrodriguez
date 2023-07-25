using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityModelStatus
    {
        public int IdRegistro { get; set; }
        public int ModeloId { get; set; }
        public byte StatusModel { get; set; }
        public int? Cantidad { get; set; }
        public int? CantidadProcesada { get; set; }
        public string ComentarioTemporal { get; set; }
        public string ComentarioDesaprobado { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public string ComentarioCambioStatus { get; set; }
        public bool? Activo { get; set; }
    }
}
