using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models.ControlPanel.ModelFeactures
{
	public class CP_Q_ModelFeature
	{
		[Key]
		public int ID_Registro { get; set; }
        public string? Titulo { get; set; }
        public string? Modelo { get; set; }
		public string? Descripcion{get;set;}
		public int PlantaID { get;set;}
		public int? Orden{get;set;}
    }
}
