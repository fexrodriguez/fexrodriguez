using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.AnpControl
{
	public class AnpListUnits
	{
		[Key]
		public int? ID { get; set; }
		public string? Text { get; set; }
	}
}
