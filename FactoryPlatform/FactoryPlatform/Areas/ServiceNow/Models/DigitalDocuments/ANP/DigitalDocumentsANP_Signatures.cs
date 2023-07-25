using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsANP_Signatures
    {
        [Key]
        public int? ID_Request { get; set; }
        public int? ProveedorID { get; set; }
        public string? Fecha { get; set; }
        public int? PlantaID{ get; set; }
        public string? ClaveProveedor { get; set; }
        public string? NombreProveedor { get; set; }
        public int? ArticuloID { get; set; }
        public string? Producto { get; set; }
        public string? Codigo { get; set; }
        public string? CodigoMedioR { get; set; }
        public string? CodigoMedio { get; set; }
        public string? Solicito { get; set; }
        public string? Ingeniero { get; set; }
        public int? OEM { get; set; }
        public int? ListaCritica { get; set; }
        public string? Razon { get; set; }
        public string? Comentarios { get; set; }
        public Decimal? CostoStandar { get; set; }
        public Decimal? NuevoPrecio { get; set; }
        public int? ConsumoAnual { get; set; }
        public Decimal? Balance { get; set; }
        public int? FallasCalidad { get; set; }
        public string? NumeroParte { get; set; }
        public string? NumeroJob { get; set; }
        public string? TipoArchivo { get; set; }
        public int? ID_FANP { get; set; }
        public int? ID_RegistroEntrada { get; set; }
        public string? DescripcionAplicacion { get; set; }
        public int? Aprobado { get; set; }
        public string? FComentarios { get; set; }
        public string? FcomentariosMedicion { get; set; }
        public string? FConclusiones { get; set; }
        public string? ConclusionesDesviacion { get; set; }
        public string? DescripcionCodigoMedio { get; set; }

    }
}
