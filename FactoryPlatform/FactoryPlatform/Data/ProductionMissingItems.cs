using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ProductionMissingItems
    {
        public int IdFaltante { get; set; }
        public int? PlantaFaltanteId { get; set; }
        public DateTime FechaFaltante { get; set; }
        public int DepartamentoId { get; set; }
        public int ReportadoPorId { get; set; }
        public int ModeloId { get; set; }
        public int CodigoFaltanteId { get; set; }
        public double CantidadFaltanteEnsamble { get; set; }
        public double CantidadFaltanteKanBan { get; set; }
        public DateTime? Eta { get; set; }
        public double? Stock { get; set; }
        public int? CompradorId { get; set; }
        public string ProblemaFaltante { get; set; }
        public int? CausaId { get; set; }
        public int? DetalleCausaId { get; set; }
        public string ComentarioCausa { get; set; }
        public int Status { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? UsuarioBajaId { get; set; }
        public string MotivoBaja { get; set; }
        public int PlantaId { get; set; }
        public int? Nivel { get; set; }
        public DateTime? FechaCierre { get; set; }
        public int? UsuarioCierreId { get; set; }
        public int? ResponsableId { get; set; }
        public int? CoordinadorAsignadoId { get; set; }
        public int? ProveedorId { get; set; }
    }
}
