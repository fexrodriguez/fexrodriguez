using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DigitalDocumentsDesviationModel
    {
        [Key]
        public int ID_Registro { get; set; }
        public string? DeviationType { get; set; }
        public string? Descripcion { get; set; }
        public string? Dpto { get; set; }
        public string? Codigo { get; set; }
        public string? OriginChange { get; set; }
        public string? Description { get; set; }
        public string? Duartion { get; set; }
        public int? Quantity { get; set; }
        public string? LimitDate { get; set; }
        public string? FechaRegistro { get; set; }
        public string? Registro { get; set; }
        public byte? Status { get; set; }
        public string? FechaAccion { get; set; }
        public string? Mgr1 { get; set; }
        public string? Mgr1Fecha { get; set; }
        public string? Mgr2 { get; set; }
        public string? Mgr2Fecha { get; set; }
        public string? Mgr3 { get; set; }
        public string? Mgr3Fecha { get; set; }
        public string? UsuarioWarranty { get; set; }
        public string? FechaWarranty { get; set; }
        public string? Comentario { get; set; }
        public string? MetodoTrazabilidad { get; set; }
        public string? UsuarioTrazabilidad { get; set; }
        public string? SupplyComment { get; set; }
        public string? FechaLiberado { get; set; }
        public string? Supply { get; set; }
        public string? Engineer { get; set; }
        public string? FechaEngineer { get; set; }
        public string? Determination { get; set; }
        public string? EngineerComments { get; set; }
        public string? Estaciones { get; set; }
        public string? Accion { get; set; }
        public string? ComentariosAccion { get; set; }
        public string? AccionCorrectiva { get; set; }
        public string? AccionResponsable { get; set; }
        public string? FechaAccionRegistro { get; set; }
    }
}
