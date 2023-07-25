using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class ProductionMaterialSequences
    {
        public int IdRegistro { get; set; }
        public byte MaterialSequencesStatus { get; set; }
        public string Family { get; set; }
        public string Job { get; set; }
        public string Item { get; set; }
        public byte ItemStatus { get; set; }
        public byte ItemCheck { get; set; }
        public string ItemHoraCompromiso { get; set; }
        public string Motor { get; set; }
        public byte MotorStatus { get; set; }
        public byte MotorCheck { get; set; }
        public string MotorHoraCompromiso { get; set; }
        public string Block { get; set; }
        public byte BlockStatus { get; set; }
        public byte BlockCheck { get; set; }
        public string BlockHoraCompromiso { get; set; }
        public string Cab1 { get; set; }
        public byte Cab1Status { get; set; }
        public byte Cab1Check { get; set; }
        public string Cab1HoraCompromiso { get; set; }
        public string Cig { get; set; }
        public byte CigStatus { get; set; }
        public byte CigCheck { get; set; }
        public string CigHoraCompromiso { get; set; }
        public string Arbol { get; set; }
        public byte ArbolStatus { get; set; }
        public byte ArbolCheck { get; set; }
        public string ArbolHoraCompromiso { get; set; }
        public string Biela { get; set; }
        public byte BielaStatus { get; set; }
        public byte BielaCheck { get; set; }
        public string BielaHoraCompromiso { get; set; }
        public string Metodo { get; set; }
        public byte MetodoStatus { get; set; }
        public string ManoDeObra { get; set; }
        public byte ManoDeObraStatus { get; set; }
        public string Maquina { get; set; }
        public byte MaquinaStatus { get; set; }
        public string Materiales { get; set; }
        public byte MaterialesStatus { get; set; }
        public string Comentarios { get; set; }
        public int UsuarioRegistroId { get; set; }
        public DateTime FechaRegistro { get; set; }
    }
}
