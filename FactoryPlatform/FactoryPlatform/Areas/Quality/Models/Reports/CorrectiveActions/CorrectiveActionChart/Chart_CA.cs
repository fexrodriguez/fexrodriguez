using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models.Reports.CorrectiveActions.CorrectiveActionChart
{
    public class Chart_CA
    {
        [Key]
        public int? IdRegistro { get; set; }
        public string? Descripcion { get; set; }
        public int? Cero { get; set; }
        public int? UnoSiete { get; set; }
        public int? MasSiete { get; set; }
        public int? none { get; set; }

    }
}
    