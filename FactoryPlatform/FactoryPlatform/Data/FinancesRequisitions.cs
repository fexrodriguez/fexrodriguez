using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class FinancesRequisitions
    {
        public int IdRequisicion { get; set; }
        public string NumeroRequisicion { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int AutorizacionGerencia { get; set; }
        public DateTime? FechaAutorizacionGerencia { get; set; }
        public int AutorizacionDireccion { get; set; }
        public DateTime? FechaAutorizacionDireccion { get; set; }
        public bool PresupuestoMaximo { get; set; }
        public bool? Retornado { get; set; }
        public string ComentarioRetorno { get; set; }
        public int CompradorId { get; set; }
        public int ProveedorId { get; set; }
        public int? CuentaId { get; set; }
        public int SubCuentaId { get; set; }
        public bool Cotizacion { get; set; }
        public string Tipo { get; set; }
        public string OrdenCompra { get; set; }
        public int OpcionCompraId { get; set; }
        public string MotivoCompra { get; set; }
        public int UsuarioBajaId { get; set; }
        public DateTime? FechaRegistroBaja { get; set; }
        public string MotivoBaja { get; set; }
        public int? UsuarioRegistroCancelacion { get; set; }
        public DateTime? FechaRegistroCancelacion { get; set; }
        public DateTime? FechaCompletada { get; set; }
        public bool? Status { get; set; }
    }
}
