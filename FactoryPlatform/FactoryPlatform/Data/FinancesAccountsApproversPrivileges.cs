using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class FinancesAccountsApproversPrivileges
    {
        public int IdRegistro { get; set; }
        public int PrivilegioId { get; set; }
        public string DescripcionTab { get; set; }
        public string Icono { get; set; }
        public string Contenido { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaRegistroId { get; set; }
        public int PlantaId { get; set; }
        public bool? Status { get; set; }
    }
}
