using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class SoftwareConfigPagesUserHistory
    {
        public int IdRegistro { get; set; }
        public int PageId { get; set; }
        public string PageTitle { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? IdSection { get; set; }
        public string PageAction { get; set; }
    }
}
