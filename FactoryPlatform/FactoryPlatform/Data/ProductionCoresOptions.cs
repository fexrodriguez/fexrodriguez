using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ProductionCoresOptions
    {
        public int IdRegistro { get; set; }
        public int CoreId { get; set; }
        public byte Opcion { get; set; }
        public int? Core { get; set; }
        public int? Block { get; set; }
        public int? CabezaDerecha { get; set; }
        public int? CabezaIzquierda { get; set; }
        public int? Ciguenal { get; set; }
        public int? Arbol { get; set; }
        public int? Arbol2 { get; set; }
        public int? Arbol3 { get; set; }
        public int? Arbol4 { get; set; }
        public int? Biela { get; set; }
        public int? TapaTiempo { get; set; }
        public string Comentarios { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public bool? Status { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? UsuarioBajaId { get; set; }
        public string MotivosBaja { get; set; }
        public int PlantaId { get; set; }
    }
}
