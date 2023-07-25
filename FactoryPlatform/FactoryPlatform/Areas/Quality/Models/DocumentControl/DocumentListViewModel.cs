using FactoryPlatform.Areas.ServiceNow.Models;
using FactoryPlatform.Data;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.Quality.Models
{
    public class DocumentListViewModel : DocViewerViewModel
    {
        //Paremetros de la pagina
        public string TituloSeccion { get; set; }
        public int? IdSeccion { get; set; }
        public string ActionPage { get; set; }
        public int Tipo { get; set; }
        //-----------------------------------

        //Parametros de la busqueda
        public int Planta {get; set;}
        public int Departamento {get; set;}
        public int Estacion {get; set;}
        public string? Clave {get; set;}
        public int Status {get; set;}
        public int Id_Usuario { get; set; }
        public string? Description { get; set; }

        public List<QualityDocsUsersPrivileges> UsersPrivileges { get; set; } = new List<QualityDocsUsersPrivileges>();
        public List<QualityDocsUsersPrivileges> PrivilageNewReview { get; set; } = new List<QualityDocsUsersPrivileges>();
        public List<QualityDocsUsersPrivileges> UpdateKey { get; set; } = new List<QualityDocsUsersPrivileges>();
        public List<QualityDocsUsersPrivileges> PrivilegeObsolete { get; set; } = new List<QualityDocsUsersPrivileges>();
        public List<StoresDocumentList> StoresDocumentList { get; set; } = new List<StoresDocumentList>();
        public List<DocumentList_Signature> DocumentList_Signature { get; set; } = new List<DocumentList_Signature>();
        public List<DocumentsKeys> DocumentsKeys { get; set; } = new List<DocumentsKeys>();


    }
}
