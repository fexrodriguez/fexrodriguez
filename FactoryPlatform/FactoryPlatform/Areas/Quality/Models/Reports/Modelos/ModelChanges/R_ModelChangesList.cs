using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelChanges
{
    public class R_ModelChangesList
    {
		[Key]
		public int? ID_Registro { get; set; }
		public string? Serie { get; set; }
		public string? PreviousModel { get; set; }
		public string? NewModel { get; set; }
		public string? RecordDate { get; set; }
		public string? RecordUser { get; set; }
	}
}
