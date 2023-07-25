using Syncfusion.Drawing;
using System;
using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class DocList_DocInf
    {
        [Key]
        public int? ID_Documento { get; set; }
        public string? Clave { get; set; }
        public int? RevisionID { get; set; }
        public string? DocType { get; set; }
        public string? Title { get; set; }
        public string? Descripcion { get; set; }
        public string? Product { get; set; }
        public string? Owner { get; set; }
        public string? RecordDate { get; set; }
        public string? StartDate { get; set; }
        public string? EstimatedEnd { get; set; }
        public string? ChangeManager { get; set; }
        public string? OriginOfChange { get; set; }
        public string? DescripcionOfChange { get; set; }
        public string? ReviewOfChange { get; set; }
        public string? ValidationOfChange { get; set; }
        public string? Workstations { get; set; }
        public string? PreApproval { get; set; }
        public string? FinalSignature { get; set; }
        public string? OrigenComentario { get; set; }
		public string? Applicant { get; set; }

        public string? Workstationid { get; set; }
        public string? PreApprovalid { get; set; }
        public string? FinalSignatureid { get; set; }

		public string? Revisions { get; set; }
		public string? TipoArchivo { get; set; }


		//Authorizations and rejects: Informacion para mostrar la ultima persona que aprobo o rechazo el documento
        public int? PlantaID { get; set; }
		public string? Tipo {get; set;}
        public string? Comentarios    {get; set;}
        public string? FechaRegistro {get; set;}
        public string? OperacionTxt    {get; set;}
        public string? Icono {get; set;}
        public string? TipoTxt    {get; set;}
        public string? Usuario { get; set; }
		public string? TipoArchivos { get; set; }
		public bool? Obsoleto { get; set; }
	}
}
