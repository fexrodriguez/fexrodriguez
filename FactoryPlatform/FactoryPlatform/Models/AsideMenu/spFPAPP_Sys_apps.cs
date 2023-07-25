using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Models
{
    public class spFPAPP_Sys_apps
    {
        [Key]
        public int ID_Aplicacion { get; set; }
        public string Aplicacion { get; set; }
        public string Direccion { get; set; }
        public int DepartamentoID { get; set; }
    }
}
