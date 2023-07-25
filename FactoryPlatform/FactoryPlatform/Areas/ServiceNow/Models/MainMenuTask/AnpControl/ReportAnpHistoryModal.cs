using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.AnpControl
{
	public class ReportAnpHistoryModal
	{
		[Key]
		public int? ID_Registro { get; set; }
		public string? ComentarioRevision { get; set; }
		public string? ComentarioLiberado { get; set; }
		public string? Icono { get; set; }
	}
}
