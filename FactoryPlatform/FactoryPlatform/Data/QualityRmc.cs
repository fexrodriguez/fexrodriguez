using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class QualityRmc
    {
        public int RegistroId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Program { get; set; }
        public string NoSerie { get; set; }
        public int? TotalTestTime { get; set; }
        public string Leak1 { get; set; }
        public string Leak2 { get; set; }
        public int? Leaktime { get; set; }
        public int? Leakmin { get; set; }
        public string Torqueresults { get; set; }
        public int? Maxtrqmeas { get; set; }
        public int? Maxtrqdeg { get; set; }
        public int? Maxtorque { get; set; }
        public string Runinresults { get; set; }
        public int? Runinrpm { get; set; }
        public int? Runinoilpsi { get; set; }
        public int? Minoilpsi { get; set; }
        public int? Maxoilpsi { get; set; }
        public int? Avgoilflow { get; set; }
        public int? Avgoiltemp { get; set; }
        public string Compresults { get; set; }
        public int? Cyl1comp { get; set; }
        public string Cyl1results { get; set; }
        public int? Cyl2comp { get; set; }
        public string Cyl2results { get; set; }
        public int? Cyl3comp { get; set; }
        public string Cyl3results { get; set; }
        public int? Cyl4comp { get; set; }
        public string Cyl4results { get; set; }
        public int? Cyl5comp { get; set; }
        public string Cyl5results { get; set; }
        public int? Cyl6comp { get; set; }
        public string Cyl6results { get; set; }
        public int? Cyl7comp { get; set; }
        public string Cyl7results { get; set; }
        public int? Cyl8comp { get; set; }
        public string Cyl8results { get; set; }
        public int? Cyl9comp { get; set; }
        public string Cyl9results { get; set; }
        public int? Cyl10comp { get; set; }
        public string Cyl10results { get; set; }
        public int? Compminpsi { get; set; }
        public int? Compmaxpsi { get; set; }
        public int? MaxTestedPsi { get; set; }
        public int? MintestedPsi { get; set; }
        public int? Noname { get; set; }
        public int? VariancePsi { get; set; }
        public string Cyldeactresults { get; set; }
        public string Cyl1deact { get; set; }
        public string Cyl4deact { get; set; }
        public string Cyl6deact { get; set; }
        public string Cyl7deact { get; set; }
        public string Vvtresults { get; set; }
        public string Vvtcyl1 { get; set; }
        public string Vvtcyl2 { get; set; }
        public string Vvtcyl5 { get; set; }
        public string Vvtcyl6 { get; set; }
        public string Leakresults { get; set; }
        public string CompTestRpm { get; set; }
        public string Linea { get; set; }
    }
}
