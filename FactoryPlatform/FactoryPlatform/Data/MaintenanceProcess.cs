using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class MaintenanceProcess
    {
        public int IdProceso { get; set; }
        public string NumeroProceso { get; set; }
        public string DescripcionProceso { get; set; }
        public int TipoMantenimientoId { get; set; }
        public DateTime FechaMantenimientoAnterior { get; set; }
        public int Intervalo { get; set; }
        public DateTime FechaMantenimientoSiguiente { get; set; }
        public int SemanaMantenimientoAnterior { get; set; }
        public int SemanaMantenimientoSiguiente { get; set; }
        public int? MaquinaId { get; set; }
        public int Prioridad { get; set; }
        public bool ServicioExterno { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int PlantaId { get; set; }
        public int Status { get; set; }
    }
}
