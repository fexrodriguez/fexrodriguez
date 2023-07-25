using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.AnpControl
{
	public class ReportAnpStep1DimensionalInspect
	{
		[Key]
		public int? ID_Caracteristica { get; set; }
		public string? Unidad { get; set; }
		public string? Minimo { get; set; }
		public string? Maximo { get; set; }
		public string? Medicion { get; set; }
		public string? Conclusion { get; set; }
		public int? FANP_ID { get; set; }
		public int? Nivel { get; set; }
		public string? DescripcionCaracteristica { get; set; }
		public int? Orden { get; set; }
		public int? Tipo { get; set; }
	}
}
