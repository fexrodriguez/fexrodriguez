using System.ComponentModel.DataAnnotations;
namespace FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureRecord
{
    public class R_ModelRecordFeatureList
    {
		[Key]
        public int? ID_Registro { get; set; }
		public string? Serie { get; set; }
		public string? Modelo { get; set; }
		public string? Workstation { get; set; }
		public string? RecordDate { get; set; }
		public string? RecordHour { get; set; }
		public string? Users { get; set; }
	}
}
