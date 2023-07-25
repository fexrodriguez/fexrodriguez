﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityModelFeaturesResultsResp23012022
    {
        public int IdRegistro { get; set; }
        public string Modelo { get; set; }
        public string Serie { get; set; }
        public byte Estacion { get; set; }
        public bool Resultado { get; set; }
        public int CaracteristicaId { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioId { get; set; }
        public int? PlantaId { get; set; }
        public byte? ModelStatus { get; set; }
    }
}
