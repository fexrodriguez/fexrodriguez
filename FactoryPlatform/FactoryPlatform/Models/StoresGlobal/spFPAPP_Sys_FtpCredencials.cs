using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Models
{
    public class spFPAPP_Sys_FtpCredencials
    {
        [Key]
        public int ID { get; set; }
        public string FtpDireccion { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
    }
}
    