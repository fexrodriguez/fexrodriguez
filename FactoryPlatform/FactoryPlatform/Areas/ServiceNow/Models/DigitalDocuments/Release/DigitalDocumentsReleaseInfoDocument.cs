using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsReleaseInfoDocument
    {
        [Key]
        public int ID_Registro { get; set; }
        public string? IDMejora { get; set; }
        public string? FechaRegistro { get; set; }
        public int? PlantaID { get; set; }
        public string? Descripcion { get; set; }
        public string? Nombre { get; set; }
        public string? Planta { get; set; }
        public string? EV { get; set; }
        public string? EVTipo { get; set; }
        public string? Aprobador { get; set; }
        public string? FechaCompromiso { get; set; }
        public string? Accions { get; set; }
        public string? ACName{ get; set; }
        public int? TypeID { get; set; }

    }
}
