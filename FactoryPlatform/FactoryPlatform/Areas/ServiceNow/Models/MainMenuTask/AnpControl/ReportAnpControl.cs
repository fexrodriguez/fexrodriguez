using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.AnpControl
{
    public class ReportAnpControl
    {
        [Key]
        public int? ID_Request { get; set; }
        public string? Codigo { get; set; }
        public string? TipoArchivo { get; set; }
		[DataType(DataType.Text)]
		public string? Buttons { get; set; }
		
		public string? NombreProveedor { get; set; }
        public string? Revision { get; set; }
        public string? Ingeniero { get; set; }
        public string? Asignado { get; set; }
        public string? Step { get; set; }
        public string? Levels { get; set; }
        public string? ComentarioRevision { get; set; }
        public string? FechaRevision { get; set; }
		public int? Rechazo { get; set; }
		public int? Garantia { get; set; }
	}
}
