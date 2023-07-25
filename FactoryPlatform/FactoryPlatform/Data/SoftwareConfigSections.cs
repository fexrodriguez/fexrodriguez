using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class SoftwareConfigSections
    {
        public SoftwareConfigSections()
        {
            SoftwareConfigPages = new HashSet<SoftwareConfigPages>();
            SoftwareConfigSectionsLinkedUsers = new HashSet<SoftwareConfigSectionsLinkedUsers>();
        }

        public int IdSeccion { get; set; }
        public string Seccion { get; set; }
        public bool? Status { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int AplicacionId { get; set; }
        public string Icono { get; set; }
        public string Direccion { get; set; }
        public bool? Original { get; set; }
        public bool InMenu { get; set; }

        public virtual SoftwareConfigApps Aplicacion { get; set; }
        public virtual ICollection<SoftwareConfigPages> SoftwareConfigPages { get; set; }
        public virtual ICollection<SoftwareConfigSectionsLinkedUsers> SoftwareConfigSectionsLinkedUsers { get; set; }
    }
}
