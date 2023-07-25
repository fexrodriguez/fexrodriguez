using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models.ControlPanel.ModelSequences
{
    public class CP_MSequencesModel
    {
		[Key]
		public int? ID_Workstation { get; set; }
		public string Workstation { get; set; }
		public byte? Secuencia { get; set; }

		public int? Registro { get; set; }
	}
}
