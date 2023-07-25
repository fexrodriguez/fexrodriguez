using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class spFPAPP_PhotoCenter_ValidateStopModel
    {
        [Key]
        public int ID { get; set; }
        public string Modelo { get; set; }
        public string Result { get; set; }
        public string MensajeAlerta { get; set; }
    }
}
