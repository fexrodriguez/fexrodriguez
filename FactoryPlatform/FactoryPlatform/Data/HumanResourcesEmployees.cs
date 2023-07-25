using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesEmployees
    {
        public int IdRegistro { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public int DepartamentoId { get; set; }
        public string Rfc { get; set; }
        public string Imss { get; set; }
        public string Curp { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public DateTime? FechaLiberacionEntrenamiento { get; set; }
        public string Puesto { get; set; }
        public int? PuestoId { get; set; }
        public string NoEmpleado { get; set; }
        public string KronosId { get; set; }
        public string Empleado { get; set; }
        public bool Status { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? UsuarioBajaId { get; set; }
        public DateTime? Visual { get; set; }
        public DateTime? Auditivo { get; set; }
        public string Categoria { get; set; }
        public int UbicacionId { get; set; }
        public int? GerenciaId { get; set; }
        public int? DepartamentoProduccionId { get; set; }
        public int? SupervisorId { get; set; }
        public int? PlantaId { get; set; }
        public int? Evaluacion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public byte? TipoEvaluacionId { get; set; }
    }
}
