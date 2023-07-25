using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class spFPAPP_Services_now_DocViewer_DocumentViewerListInfo
    {
        [Key]
        public int ID_Documento { get; set; }
        public int? PlantaID { get; set; }
        public string? Clave { get; set; }
        public string? Descripcion { get; set; }
        public int? Formato { get; set; }
        public byte? TipoDigital { get; set; }
        public int? DigitalID { get; set; }
        public string? Ruta { get; set; }
        public int? RevisionID { get; set; }
        public string? TipoArchivo { get; set; }
    }
}
