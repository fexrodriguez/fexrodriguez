using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesSurveys
    {
        public int IdEncuesta { get; set; }
        public string DescripcionEncuesta { get; set; }
        public int YearId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int? PlantaId { get; set; }
        public bool? Status { get; set; }
    }
}
