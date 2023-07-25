using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringFanpInputData
    {
        public int IdRegistroEntrada { get; set; }
        public int RequestId { get; set; }
        public int FanpId { get; set; }
        public string DescripcionAplicacion { get; set; }
        public bool ServicioInterno { get; set; }
        public string Comentarios { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public string ComentariosMedicion { get; set; }
        public bool? Aprobada { get; set; }
        public string Conclusiones { get; set; }
        public string ConclusionesDesviacion { get; set; }
        public bool Modificado { get; set; }
        public bool? Status { get; set; }
    }
}
