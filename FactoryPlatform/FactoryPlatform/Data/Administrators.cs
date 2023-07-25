using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class Administrators
    {
        public int IdAdministrador { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Extension { get; set; }
        public string Correo { get; set; }
        public int DepartamentoId { get; set; }
        public string Puesto { get; set; }
        public int? UsuarioId { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public string PreguntaSecreta { get; set; }
        public string RespuestaSecreta { get; set; }
        public bool? Status { get; set; }
        public DateTime FechaRegistro { get; set; }
        public string Categoria { get; set; }

        public virtual Departments Departamento { get; set; }
    }
}
