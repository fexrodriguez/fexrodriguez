using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityDocsOriginChange
    {
        public int IdRegistro { get; set; }
        public int? Value { get; set; }
        public string Titulo { get; set; }
        public bool? Status { get; set; }
        public DateTime? FechaRegistro { get; set; }
    }
}
