using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityMetrolGages
    {
        public int IdGage { get; set; }
        public string NumeroGage { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FechaCalibracionAnterior { get; set; }
        public int? Intervalo { get; set; }
        public DateTime? FechaCalibracionSiguiente { get; set; }
        public string GrupoId { get; set; }
        public string Fabricante { get; set; }
        public string LlamadaAnterior { get; set; }
        public string Locacion { get; set; }
        public int? EstacionId { get; set; }
        public DateTime? FechaCompra { get; set; }
        public int? DepartamentoId { get; set; }
        public double? Precio { get; set; }
        public string Modelo { get; set; }
        public string Calibracion { get; set; }
        public string CalibracionExterna { get; set; }
        public int? ProveedorId { get; set; }
        public string Comentarios { get; set; }
        public string Rango { get; set; }
        public string MedidaRango { get; set; }
        public int? UsuarioOwnerId { get; set; }
        public string UsuarioOwnerStr { get; set; }
        public string NumeroSerie { get; set; }
        public string Activo { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public int? UsuarioRegistroId { get; set; }
        public int? PlantaId { get; set; }
        public int? Status { get; set; }
        public int? SubStatus { get; set; }
    }
}
