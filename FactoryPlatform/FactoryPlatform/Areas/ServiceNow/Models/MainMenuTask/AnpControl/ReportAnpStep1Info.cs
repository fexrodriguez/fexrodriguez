using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.AnpControl
{
	public class ReportAnpStep1Info
	{
		[Key]
		public int ID_Request { get; set; }
		public int? ArticuloID { get; set; }
		public int? ProveedorID { get; set; }
		public int? OEM { get; set; }
		public int? ListaCritica { get; set; }
		public string CodigoMedio { get; set; }
		public int? ID_FANP { get; set; }
		public string Codigo { get; set; }
		public int? ID_RegistroEntrada { get; set; }
		public string DescripcionAplicacion { get; set; }
		public int? ServicioInterno { get; set; }
		public string Comentarios { get; set; }
		public string? Garantia { get; set; }
	}
}
