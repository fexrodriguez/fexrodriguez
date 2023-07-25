using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ImportUsers
    {
        public double? IdUsuario { get; set; }
        public string Nombres { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public double? DepartamentoId { get; set; }
        public string Rfc { get; set; }
        public string Imss { get; set; }
        public string Curp { get; set; }
        public string FechaIngreso { get; set; }
        public string FechaLiberacionEntrenamiento { get; set; }
        public string Puesto { get; set; }
        public string PuestoId { get; set; }
        public string NoEmpleado { get; set; }
        public string Usuario { get; set; }
        public string Pass { get; set; }
        public string PreguntaSecreta { get; set; }
        public string RespuestaSecreta { get; set; }
        public double? Status { get; set; }
        public string FechaBaja { get; set; }
        public string UsuarioBajaId { get; set; }
        public DateTime? FechaRegistro { get; set; }
        public string PaginaInicio { get; set; }
        public string Idioma { get; set; }
        public string Categoria { get; set; }
        public double? UbicacionId { get; set; }
        public string GerenciaId { get; set; }
        public string DepartamentoProduccionId { get; set; }
        public string SupervisorId { get; set; }
        public double? PlantaId { get; set; }
    }
}
