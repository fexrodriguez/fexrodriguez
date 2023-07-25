using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class LogisiticsRequestNewProduct
    {
        public int IdRequest { get; set; }
        public string FolioSyt { get; set; }
        public int ProveedorId { get; set; }
        public int ArticuloId { get; set; }
        public string CodigoMedio { get; set; }
        public bool Ensamble { get; set; }
        public int CantidadEnsamble { get; set; }
        public int? Oem { get; set; }
        public int? ListaCritica { get; set; }
        public int? ListaCriticaUpdate { get; set; }
        public int? TipoArchivo { get; set; }
        public string Razon { get; set; }
        public string NumeroJob { get; set; }
        public string NumeroParte { get; set; }
        public string Comentarios { get; set; }
        public decimal? CostoStandar { get; set; }
        public decimal? NuevoPrecio { get; set; }
        public int? ConsumoAnual { get; set; }
        public decimal? Balance { get; set; }
        public int? FallasCalidad { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public DateTime? FechaRegistroAprobacion1 { get; set; }
        public int? UsuarioRegistroIdaprobacion1 { get; set; }
        public DateTime? FechaRegistroAprobacion2 { get; set; }
        public int? UsuarioRegistroIdaprobacion2 { get; set; }
        public DateTime? FechaRegistroAprobacion3 { get; set; }
        public int? UsuarioRegistroIdaprobacion3 { get; set; }
        public int? UsuarioIngenieroId { get; set; }
        public int? UsuarioCalidadId { get; set; }
        public int? UsuarioDocumentosId { get; set; }
        public int? UsuarioPartesCriticasId { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? UsuarioRegistroBajaId { get; set; }
        public string MotivoBaja { get; set; }
        public DateTime? FechaRevisionDibujo { get; set; }
        public int? UsuarioRevisionDibujoId { get; set; }
        public DateTime? FechaCompletada { get; set; }
        public int? UsuarioCompletoId { get; set; }
        public int? Prioridad { get; set; }
        public bool? ActivaPrioridad { get; set; }
        public DateTime? FechaModificaPrioridad { get; set; }
        public int? PlantaId { get; set; }
        public int? Status { get; set; }
        public int? TipoId { get; set; }
        public bool? AsignacionIngeniero { get; set; }
    }
}
