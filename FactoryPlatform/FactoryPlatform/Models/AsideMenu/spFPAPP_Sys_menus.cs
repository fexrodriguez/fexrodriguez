using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Models
{
    public class spFPAPP_Sys_menus
    {
        [Key]
        public int Id_Departamento { get; set; }
        public string Departamento { get; set; }
        public string Iconos { get; set; }
    }
}
