using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class LogisticsMarchingReportDelete
    {
        public int IdRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Atk { get; set; }
        public string Core { get; set; }
        public string Vege { get; set; }
        public string Part { get; set; }
        public string Line { get; set; }
        public string LineData { get; set; }
        public string Planta { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int UsuarioRegistroDeleteId { get; set; }
        public DateTime FechaRegistroDelete { get; set; }
        public string LineMarching { get; set; }
    }
}
