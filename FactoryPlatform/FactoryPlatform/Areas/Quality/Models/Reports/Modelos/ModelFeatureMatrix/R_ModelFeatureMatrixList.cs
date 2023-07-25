using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models.Reports.Modelos.ModelFeatureMatrix
{
    public class R_ModelFeatureMatrixList
    {
		[Key]
		public int ID_Registro { get; set; }
		public string Modelo { get; set; }
		public string? Lavado { get; set; }
		public string? Ensamble1 { get; set; }
		public string? Ensamble2 { get; set; }
		public string? Ensamble3 { get; set; }
		public string? Ensamble4 { get; set; }
		public string? Ensamble5 { get; set; }
		public string? Ensamble6 { get; set; }


	}
}
