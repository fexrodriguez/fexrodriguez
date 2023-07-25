using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class spFPAPP_QualityControl_ModelFeatures_SaveFeature
    {
        [Key]
        public int ID { get; set; }
        public string Correct { get; set; }
    }
}
