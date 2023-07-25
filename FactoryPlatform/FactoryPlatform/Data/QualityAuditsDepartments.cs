﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityAuditsDepartments
    {
        public int IdDepartamento { get; set; }
        public string Clave { get; set; }
        public string Departamento { get; set; }
        public bool Status { get; set; }
        public bool? Audit { get; set; }
        public int? PlantaId { get; set; }
    }
}
