using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class DocumentList_Signature
    {
        [Key]
        public int? ID_Registro { get; set; }
        public int? Nivel { get; set; }
        public string? Iconos { get; set; }
        public string? Color { get; set; }
        public string? StatusTexto { get; set; }
        public string? UsuarioVoBo { get; set; }
        public string? FechaRegistro { get; set; }
        public int? TipoFirma { get; set; }
        public int? DocumentoId { get; set; }
    }
}
