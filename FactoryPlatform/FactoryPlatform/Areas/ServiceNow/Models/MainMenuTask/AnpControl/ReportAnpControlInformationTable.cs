using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.AnpControl
{
    public class ReportAnpControlInformationTable
    {
        [Key]
        public int? IDRegistroProvider { get; set; }
        public string? ItemVendor { get; set; }
        public int? ProveedorID { get; set; }
        public string? NombreProveedor { get; set; }
        public string? Codigo { get; set; }
        public decimal? CostoSTD { get; set; }
        public int? Aprovado { get; set; }

    }
}
