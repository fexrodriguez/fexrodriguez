using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class CatPicEntry
    {
        public int? Id { get; set; }
        public int? CatPicLineId { get; set; }
        public int? CatPicLocationId { get; set; }
        public int? ProductId { get; set; }
        public int? BomId { get; set; }
        public string NameOverride { get; set; }
        public string Comments { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string OrderNumber { get; set; }
    }
}
