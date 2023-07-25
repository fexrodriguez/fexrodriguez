using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringComponentsFeaturesSpecificationsDetails
    {
        public int IdRegistro { get; set; }
        public int EspecificacionId { get; set; }
        public int ComponenteId { get; set; }
        public int CodigoModeloId { get; set; }
        public int CaracteristicaId { get; set; }
        public int TipoId { get; set; }
        public int UnidadMedidaId { get; set; }
        public string Minimo { get; set; }
        public string Maximo { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public bool? Status { get; set; }
    }
}
