using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;

namespace FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.AnpControl
{
	public class ReportAnpStep1DimensionalSpecifications
	{
		[Key]
		public int? ID_Caracteristica { get; set; }
		public string? Unidad { get; set; }
		public string? Minimo { get; set; }
		public string? Maximo { get; set; }
		public int? FanpID { get; set; }
		public int? Nivel { get; set; }
		public string? DescripcionCaracteristica { get; set; }
		public int? Orden { get; set; }
		public int? Tipo { get; set; }

	}
}
