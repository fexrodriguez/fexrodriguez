using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityAuditsAuditEnvironmentalCulture
    {
        public int IdRegistroCultura { get; set; }
        public int? AuditPlannerId { get; set; }
        public int? InputId { get; set; }
        public int? TemplateId { get; set; }
        public string Medicion { get; set; }
        public string Resultado { get; set; }
        public string Comentario { get; set; }
        public int? UsuarioResponsableId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsuarioaRegistroId { get; set; }
        public string Alerta { get; set; }
        public DateTime? FechaArranque { get; set; }
        public bool? Status { get; set; }
    }
}
