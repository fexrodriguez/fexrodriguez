using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesDepartments
    {
        public int IdDepartamento { get; set; }
        public string Clave { get; set; }
        public string Departamento { get; set; }
        public string IconoMenu { get; set; }
        public string PaginaPrincipal { get; set; }
        public bool Status { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string IconClass { get; set; }
        public string CarpetaSite { get; set; }
    }
}
