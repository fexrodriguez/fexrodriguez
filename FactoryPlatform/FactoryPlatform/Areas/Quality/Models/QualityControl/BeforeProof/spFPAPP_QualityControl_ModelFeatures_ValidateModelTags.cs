using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class spFPAPP_QualityControl_ModelFeatures_ValidateModelTags
    {
        [Key]
        public int ID { get; set; }
        public string Result { get; set; }
    }
}
