using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class PreApprovalModel
    {
        [Key]
        public int? ID_Documento { get; set; }
        public int? RevisionID    {get; set;}
		public string? Clave { get; set; }
		public string? TipoArchivo { get; set;}
        public string? OrigenComentario {get; set;}
        public string? Descripcion {get; set;}
        public string? Responsable {get; set;}
        public string? PreApproval    {get; set;}
        public string? PreApprovalIco {get; set;}
        public string? PreApprovalTx    {get; set;}
        public string? FinalSignature {get; set;}
        public string? FinalSignatureIco    {get; set;}
        public string? FinalSignatureTx{get; set;}
        public string? StatusDoc { get; set;}
    }
}
