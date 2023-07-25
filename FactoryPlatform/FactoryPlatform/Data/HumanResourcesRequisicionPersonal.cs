using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesRequisicionPersonal
    {
        public int IdRegistro { get; set; }
        public int PuestoId { get; set; }
        public int QtyPersonas { get; set; }
        public int Gerencia { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Expide { get; set; }
        public byte Posicion { get; set; }
        public string Observaciones { get; set; }
        public int Edad { get; set; }
        public int EdadFin { get; set; }
        public byte EstadoCivil { get; set; }
        public byte Sexo { get; set; }
        public byte Escolaridad { get; set; }
        public string Especificar { get; set; }
        public double? Sueldo { get; set; }
        public DateTime? Recepcion { get; set; }
        public DateTime? Contratacion { get; set; }
        public byte? Status { get; set; }
        public int? WorkstationId { get; set; }
        public int? DepartamentoId { get; set; }
        public int? HorarioId { get; set; }
        public int? ReemplazoId { get; set; }
        public string UltimoNivel { get; set; }
        public int? PreferenciaEscolaridad { get; set; }
        public int? ContratacionId { get; set; }
        public int? Linea { get; set; }
    }
}
