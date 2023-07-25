using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class Quality_Docs_DocumentsTypes
    {
        [Key]
        public int ID_Tipo { get; set; }
        public string Descripcion { get; set; }
    }
}
