using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Models
{
        public class Users
        {
            [Key]
            public int Id_Usuario { get; set; }
            public string Usuario { get; set; }
            public string Correo { get; set; }
            public string PasswordHash { get; set; }
            public string Salt { get; set; }
            public bool Status { get; set; }
            public int PlantaId { get; set; }
        }
}
