using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class UpdateKey
    {
        [Key]
        public int? Id_Registro { get; set; }
        public string? ClaveOriginal { get; set; }
		public int PlantaID { get; set; }

	}
}
