using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.AnpControl
{
	public class AnpStep1Paso1
	{
		[Key]
		public int? CaracteristicaID { get; set; }
		public string? Unidad { get; set; }
		public string? Minimo { get; set; }
		public string? Maximo { get; set; }
		public string? Medicion { get; set; }
		public string? Conclusion { get; set; }

	}
}
