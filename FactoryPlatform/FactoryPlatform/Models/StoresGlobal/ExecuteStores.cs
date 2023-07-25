using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Models
{
    public class ExecuteStores
    {
        [Key]
        public int? ID { get; set; }
        public string? Resultado { get; set; }
    }
}
