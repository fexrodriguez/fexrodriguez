using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DocumentTrainingStep1
    {
        [Key]
        public int DocumentoID { get; set; }
        public string Origen { get; set; }
        public string Descripcion { get; set; }
        public string Revision { get; set; }
        public string ClaveDoc { get; set; }
        public int RevisionID { get; set; }
        public int PlantaID { get; set; }
        public string? OrigenComentario { get; set; }
        public string? Responsable { get; set; }
        public bool? Obsoleto { get; set; }
    }
}
