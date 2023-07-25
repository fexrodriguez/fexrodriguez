using FactoryPlatform.Areas.Quality.Models;
using FactoryPlatform.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DocsEditionTaskModel
    {
        public int? Id_Usuario { get; set; }

        public List<DocsEditStoreModel> DocsEdition { get; set; } = new List<DocsEditStoreModel>();

        public List<QualityDocsUsersPrivileges> UsersPrivileges { get; set; } = new List<QualityDocsUsersPrivileges>();
        public List<QualityDocsUsersPrivileges> PrivilageNewReview { get; set; } = new List<QualityDocsUsersPrivileges>();
        public List<DocumentList_Signature> DocumentList_Signature { get; set; } = new List<DocumentList_Signature>();
       
        
        public List<SelectListItem> OriginChange { get; set; } = new List<SelectListItem>();
        public List<UsersReponsables> UsersReponsables { get; set; } = new List<UsersReponsables>();
        public List<Production_Stations> ProductionStations { get; set; } = new List<Production_Stations>();


    }
}
