using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityCorrectiveActionsUpdate
    {
        public int IdRegistro { get; set; }
        public int ActionId { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int IdFuente { get; set; }
        public int IdDepartamento { get; set; }
        public int ResponsableActividadId { get; set; }
        public string Causas { get; set; }
        public string Acciones { get; set; }
        public byte CategoriaAccion { get; set; }
        public int IdProceso { get; set; }
    }
}
