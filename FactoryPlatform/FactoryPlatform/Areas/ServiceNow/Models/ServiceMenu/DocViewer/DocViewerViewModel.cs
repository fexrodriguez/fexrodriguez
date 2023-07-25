using FactoryPlatform.Areas.Quality.Models;
using FactoryPlatform.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class DocViewerViewModel
    {
        public List<Services_Factories> Factories { get; set; } = new List<Services_Factories>();
        public List<Production_Stations> ProductionStations { get; set; } = new List<Production_Stations>();
        public List<Quality_Docs_DocumentsTypes> Quality_Docs_DocumentsTypes { get; set; } = new List<Quality_Docs_DocumentsTypes>();
        public List<DocumentsKeys> DocumentsKeys { get; set; } = new List<DocumentsKeys>();
        public List<SelectListItem> OriginChange { get; set; } = new List<SelectListItem>();
        public List<Keys_longitud> Keys_longitud { get; set; } = new List<Keys_longitud>();
        public List<UsersReponsables> UsersReponsables  { get; set; } = new List<UsersReponsables>();
        public List<Production_Departments> ProductionDepartments { get; set; } = new List<Production_Departments>();

    }
}
