using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models.ControlPanel.UpdModelToSerie
{
    public class CP_SerieSearch
    {
        [Key]
        public  int? ID { get; set; }
        public  string? Modelo { get; set; }
    }
}
