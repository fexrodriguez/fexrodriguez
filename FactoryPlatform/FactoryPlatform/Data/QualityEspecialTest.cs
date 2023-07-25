using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityEspecialTest
    {
        public int IdRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int? CodigoId { get; set; }
        public int? FolioAnp { get; set; }
        public string Serie { get; set; }
        public int Cantidad { get; set; }
        public int ResponsablePruebaId { get; set; }
        public int? ResponsableImpresionId { get; set; }
        public bool ServicioInterno { get; set; }
        public string Causa { get; set; }
        public string Objetivo { get; set; }
        public bool? Aceptacion { get; set; }
        public byte? Status { get; set; }
        public int? UnidadNegocioId { get; set; }
        public int? UnidadNegocioSecondId { get; set; }
        public int? ResponsableProduccionId { get; set; }
    }
}
