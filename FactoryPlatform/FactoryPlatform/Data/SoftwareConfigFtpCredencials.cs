using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class SoftwareConfigFtpCredencials
    {
        public int IdRegistro { get; set; }
        public string FtpDireccion { get; set; }
        public string Usuario { get; set; }
        public byte[] Password { get; set; }
    }
}
