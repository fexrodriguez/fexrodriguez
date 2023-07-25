using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityCorrectiveActions
    {
        public int IdRegistro { get; set; }
        public string Clave { get; set; }
        public int HerramientaId { get; set; }
        public int FuenteId { get; set; }
        public int DepartamentoId { get; set; }
        public int ResponsableSeguimientoId { get; set; }
        public int ResponsableActividadId { get; set; }
        public DateTime FechaApertura { get; set; }
        public DateTime? FechaPromesa { get; set; }
        public string Causas { get; set; }
        public string Acciones { get; set; }
        public DateTime? FechaCierre { get; set; }
        public int? CerradoPorId { get; set; }
        public int? TipoSolucionId { get; set; }
        public string Raspfamilia { get; set; }
        public string RaspfailureCode { get; set; }
        public int UsuarioId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string TipoArchivoEvidencia { get; set; }
        public byte? CategoriaAccion { get; set; }
        public int? PlantaId { get; set; }
        public string ComentariosVerificacion { get; set; }
        public bool Verificado { get; set; }
        public int? VerificadorId { get; set; }
        public DateTime? FechaVerificacion { get; set; }
        public string TipoArchivoAnalisisProblema { get; set; }
        public int? ProcesoId { get; set; }
        public bool? ClaveAutomatica { get; set; }
        public byte? Status { get; set; }
    }
}
