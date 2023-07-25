using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Models
{
    public class spFPAPP_Sys_SectionPages
    {
        [Key]
        public int ID_Seccion { get; set; }
        public string Seccions { get; set; }
        public string Direccion { get; set; }
        public int Tipo { get; set; }
    }
}
