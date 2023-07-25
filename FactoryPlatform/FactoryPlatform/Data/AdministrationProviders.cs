using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class AdministrationProviders
    {
        public int IdProveedor { get; set; }
        public string NombreProveedor { get; set; }
        public string GiroProveedor { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Contacto { get; set; }
        public string CorreoContacto { get; set; }
        public string MetodoEntrega { get; set; }
        public string TiempoEntrega { get; set; }
        public bool? Status { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public int? UsuarioBajaId { get; set; }
        public DateTime? FechaBaja { get; set; }
        public string MotivoBaja { get; set; }
        public int PlantaId { get; set; }
    }
}
