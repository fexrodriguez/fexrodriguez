using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityAuditsTemplates
    {
        public int IdRegistro { get; set; }
        public int? InputId { get; set; }
        public int? AuditoriaId { get; set; }
        public int? LineaId { get; set; }
        public int? EstacionId { get; set; }
        public string Maquina { get; set; }
        public string Descripcion { get; set; }
        public string Caracteristica { get; set; }
        public string Unidad { get; set; }
        public string Minimo { get; set; }
        public string Maximo { get; set; }
        public bool? Status { get; set; }
    }
}
