using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class LogisiticsProviders
    {
        public int IdProveedor { get; set; }
        public string Clave { get; set; }
        public string NombreProveedor { get; set; }
        public string CodigoImportacion { get; set; }
        public string DireccionProveedor { get; set; }
        public string DireccionProveedor2 { get; set; }
        public string DireccionContacto { get; set; }
        public string EmailContactoProveedor { get; set; }
        public string CiudadContactoProveedor { get; set; }
        public string InicialEstadoProveedor { get; set; }
        public string CodigoPostalProveedor { get; set; }
        public string Estado { get; set; }
        public string PaisProveedor { get; set; }
        public string Determinacion { get; set; }
        public string TiempoEntrega { get; set; }
        public string Idioma { get; set; }
        public string Moneda { get; set; }
        public string CodigoBancario { get; set; }
        public string Tipo { get; set; }
        public string WareHouse { get; set; }
        public int? CompradorId { get; set; }
        public string Vendedor { get; set; }
        public string NombreVendedor { get; set; }
        public string DireccionVendedor { get; set; }
        public string DireccionVendedor2 { get; set; }
        public string CodigoPostalVendedor { get; set; }
        public string PaisVendedor { get; set; }
        public string CuentaCompras { get; set; }
        public string DescripcionCuentaCompras { get; set; }
        public string TipoPago { get; set; }
        public bool? Ticket { get; set; }
        public string AutoTicket { get; set; }
        public string ContactoProveedor { get; set; }
        public string Telefono { get; set; }
        public string Fax { get; set; }
        public string OtroContacto { get; set; }
        public string EmailExterno { get; set; }
        public string EmailInterno { get; set; }
        public string Urlinternet { get; set; }
        public bool? IncludeTax { get; set; }
        public string Rfc { get; set; }
        public bool? DataOem { get; set; }
        public decimal? Iva { get; set; }
        public DateTime? FechaUltimaCompra { get; set; }
        public string ContactoPrimario { get; set; }
        public string EnvioDirecto { get; set; }
        public bool? FacturaDirecta { get; set; }
        public string GrupoContacto { get; set; }
        public string NombreContacto { get; set; }
        public int? PlantaId { get; set; }
        public int? UsuarioIdregistro { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsuarioIdfirma { get; set; }
        public DateTime? FechaFirma { get; set; }
        public int? UsuarioIdrechazo { get; set; }
        public DateTime? FechaRechazo { get; set; }
        public int? UsuarioIdbaja { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string ComentarioBaja { get; set; }
        public bool? Status { get; set; }
    }
}
