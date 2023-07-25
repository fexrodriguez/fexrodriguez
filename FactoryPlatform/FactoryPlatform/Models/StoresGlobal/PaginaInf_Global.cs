using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Models.StoresGlobal
{
    public class PaginaInf_Global
    {
        [Key]
        public int? IdSection { get; set; }
        public string? PageTitle { get; set; }
        public string? NewDireccion { get; set; }
        public int? Tipo { get; set; }
        public int? PageID { get; set; }
    }
}
