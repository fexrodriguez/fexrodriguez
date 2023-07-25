using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringMeasurementUnits
    {
        public int IdUnidad { get; set; }
        public string DescripcionUnidad { get; set; }
        public string Medida { get; set; }
        public int? Tipo { get; set; }
        public bool? Status { get; set; }
    }
}
