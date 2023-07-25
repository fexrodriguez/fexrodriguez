using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesTrainingRequestOperations
    {
        public int IdSolicitud { get; set; }
        public int UnidadNegocioId { get; set; }
        public int DepartamentoId { get; set; }
        public int EstacionId { get; set; }
        public int UsuarioEmpleadoId { get; set; }
        public int UsuarioEntrenoId { get; set; }
        public string TipoEntrenamiento { get; set; }
        public string Resultado { get; set; }
        public string EntrenamientoStep { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistroId { get; set; }
        public string EvaluacionEntrenamiento { get; set; }
        public string Comentarios { get; set; }
        public int? UsuarioInspectorId { get; set; }
        public string ComentariosRechazoInspector { get; set; }
        public string Conclusiones { get; set; }
        public bool? Status { get; set; }
    }
}
