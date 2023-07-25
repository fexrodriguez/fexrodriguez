using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Models
{
    public class Users_ValidationSession
    {
        [Key]
        public int Val_Id_Validacion { get; set; }
        public string IDSesion { get; set; }
        public string Usuario { get; set; }
        public int? UsuarioId { get; set; }
        public DateTime FechaReg { get; set; }
        public int TipoSesion { get; set; }
        public bool? Status { get; set; }
        public DateTime? FechaCierreSesion { get; set; }
    }
}
