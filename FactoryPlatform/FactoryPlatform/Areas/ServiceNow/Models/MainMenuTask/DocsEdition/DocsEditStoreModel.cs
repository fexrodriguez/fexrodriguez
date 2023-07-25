using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DocsEditStoreModel
    {
        [Key]
        public int? ID_Documento {get; set;}
        public int? RevisionID { get; set;}
        public string? StatusDoc   {get; set;}
        public string? StatusColor {get; set;}
        public string? Clave   {get; set;}
        public string? DescDoc {get; set;}
        public string? Comentarios {get; set;}
        public string? DocType {get; set;}
        public string? Workstations    {get; set;}
        public string? PreApproval {get; set;}
        public string? PreApprovalIco  {get; set;}
        public string? PreApprovalTx {get; set;}
        public string? FinalSignature  {get; set;}
        public string? FinalSignatureIco {get; set;}
        public string? FinalSignatureTx    {get; set;}
        public string? ComentarioRechazo { get; set; }
    }
}
