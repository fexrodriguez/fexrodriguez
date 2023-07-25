using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.AnpControl
{
    public class ReportAnpControlInformation
    {
        [Key]
        public int? ID_Request { get; set; }
        [DataType(DataType.Text)]
        public string? Clave { get; set; }
        [DataType(DataType.Text)]
        public string? NombreProveedor { get; set; }
        [DataType(DataType.Text)]
        public string? Producto { get; set; }
        [DataType(DataType.Text)]
        public string? Comprador { get; set; }
        [DataType(DataType.Text)]
        public string? Ingeniero { get; set; }
        [DataType(DataType.Text)]
        public string? Calidad { get; set; }
        [DataType(DataType.Text)]
        public string? CodigoMedio { get; set; }
        public int? OEM { get; set; }
        public int? ListaCritica { get; set; }
        [DataType(DataType.Text)]
        public string? Razon { get; set; }
        [DataType(DataType.Text)]
        public string? Comentarios { get; set; }
        public decimal? CostoStandar { get; set; }
        public decimal? NuevoPrecio { get; set; }
        public int? ConsumoAnual { get; set; }
        public decimal? Balance { get; set; }
        public int? FallasCalidad { get; set; }
        [DataType(DataType.Text)]
        public string? NumeroParte { get; set; }
        [DataType(DataType.Text)]
        public string? NumeroJob { get; set; }
        [DataType(DataType.Text)]
        public string? TipoArchivo { get; set; }
        public int? ArticuloID { get; set; }
        public int? ProveedorID { get; set; }
        [DataType(DataType.Text)]
        public string? Codigo { get; set; }


	}
}
