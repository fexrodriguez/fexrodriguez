using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{ 
    public class DocumentsKeys
{
    [Key]
    public int? ID_Tipo { get; set; }
    public string? ClaveTipoDoc { get; set; }
    public string? DescTipoDoc { get; set; }
    public string? Ejemplo { get; set; }

}
}
