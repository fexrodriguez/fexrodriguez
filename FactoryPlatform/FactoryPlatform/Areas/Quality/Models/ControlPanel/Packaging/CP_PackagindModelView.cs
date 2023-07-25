using System.Collections.Generic;

namespace FactoryPlatform.Areas.Quality.Models.ControlPanel.Packaging
{
    public class CP_PackagindModelView
    {
        public int? IdSeccion { get; set; }
        public string TituloSeccion { get; set; }
        public int? Tipo { get; set; }

        public List<PackagingLists> Hucales { get; set; } = new List<PackagingLists>();
        public List<PackagingLists> TUB_PlasticInsert { get; set; } = new List<PackagingLists>();
        public List<PackagingLists> TUB_WoodInsert { get; set; } = new List<PackagingLists>();
        public List<PackagingLists> TUB_Lid { get; set; } = new List<PackagingLists>();
        public List<CP_TubBase> CP_TubBase { get; set; } = new List<CP_TubBase>();
        public List<PackagingLists> Problem { get; set; } = new List<PackagingLists>();

    }
}
