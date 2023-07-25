using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Models
{
    public class spFPAPP_Sys_pageValidation
    {
        [Key]
        public int ID { get; set; }
        public int Respuesta { get; set; }
        public string Pagina { get; set; }
        public string Tipo { get; set; }
    }
}
