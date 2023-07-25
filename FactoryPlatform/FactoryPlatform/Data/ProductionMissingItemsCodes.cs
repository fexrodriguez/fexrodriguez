using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ProductionMissingItemsCodes
    {
        public int IdCodigo { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public string CodigoAlterno { get; set; }
        public string CodigoMedio { get; set; }
        public int? CompradorId { get; set; }
        public string TipoArticulo { get; set; }
        public string Origen { get; set; }
        public int? CodigoProducto { get; set; }
        public string CodigoAbc { get; set; }
        public decimal? CostoStd { get; set; }
        public string Unidad { get; set; }
        public double? Inventario { get; set; }
        public string CodigoVege { get; set; }
        public string CodigoAtk { get; set; }
        public string NumeroVin { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaActualizado { get; set; }
        public int? UsuarioActualizoId { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? UsuarioBajaId { get; set; }
        public string MotivoBaja { get; set; }
        public string Comentario { get; set; }
        public int PlantaId { get; set; }
        public bool? InsertSyt { get; set; }
        public bool? Status { get; set; }
    }
}
