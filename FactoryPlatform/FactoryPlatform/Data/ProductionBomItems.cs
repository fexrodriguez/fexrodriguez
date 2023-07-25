using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ProductionBomItems
    {
        public int IdItem { get; set; }
        public string Item { get; set; }
        public int ModeloId { get; set; }
        public double Cantidad { get; set; }
        public double PorcentajeUso { get; set; }
        public string Codigo { get; set; }
        public bool? Status { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime? FechaBaja { get; set; }
        public int? UsuarioBajaId { get; set; }
        public string MotivoBaja { get; set; }
        public int PlantaId { get; set; }
    }
}
