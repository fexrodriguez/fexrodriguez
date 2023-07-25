using FactoryPlatform.Areas.Quality.Models.ControlPanel.Modelos;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureRecord
{
	public class R_ModelFeatureRecordListViewModel
	{
		public int? IdSeccion { get; set; }
		public string TituloSeccion { get; set; }
		public int? Tipo { get; set; }

		public List<SelectOptionsModels> WorkStation { get; set; } = new List<SelectOptionsModels>();
		public List<SelectOptionsModels> Employees { get; set; } = new List<SelectOptionsModels>();
		
	}
}
