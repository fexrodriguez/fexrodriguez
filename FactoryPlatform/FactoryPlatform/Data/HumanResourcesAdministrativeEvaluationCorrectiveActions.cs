using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class HumanResourcesAdministrativeEvaluationCorrectiveActions
    {
        public int IdRegisto { get; set; }
        public byte CorrectiveOpen { get; set; }
        public byte CorrectiveCloseInTime { get; set; }
        public byte CorrectiveCloseOutTime { get; set; }
        public int Cumplimiento { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistroId { get; set; }
        public int EvaluationId { get; set; }
    }
}
