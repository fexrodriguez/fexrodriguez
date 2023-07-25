using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class StoresDocumentList
    {
        [Key]
        public int? ID_Documento { get; set; }
        public int? RevisionID { get; set; }
        [DataType(DataType.Text)]
        public string? TipoArchivo { get; set; }
        [DataType(DataType.Text)]
        public string? StatusDocTxt { get; set; }
        [DataType(DataType.Text)]
        public string? StatusColor { get; set; }
        [DataType(DataType.Text)]
        public string? Background { get; set; }
        [DataType(DataType.Text)]
        public string? Clave { get; set; }
        [DataType(DataType.Text)]
        public string? DescDoc { get; set; }
        [DataType(DataType.Text)]
        public string? DescDoc2 { get; set; }
        [DataType(DataType.Text)]
        public string? Comentarios { get; set; }
        [DataType(DataType.Text)]
        public string? FechaRegistroDoc { get; set; }
        [DataType(DataType.Text)]
        public string? UsuarioRegistro { get; set; }
        [DataType(DataType.Text)]
        public string? DateRevision { get; set; }
        [DataType(DataType.Text)]
        public string? ChangeDescription { get; set; }
        public int? CantidadAperturas { get; set; }
        [DataType(DataType.Text)]
        public string? ResponsableChange { get; set; }
        [DataType(DataType.Text)]
        public string? Solicitante { get; set; }
        public int? Privilegio { get; set; }
        public int? DigitalID { get; set; }
        [DataType(DataType.Text)]
        public string? Ruta { get; set; }
        [DataType(DataType.Text)]
        public string Stations { get; set; }
        public byte? TipoDigital { get; set; }

    }
}
