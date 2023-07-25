﻿using System.Collections.Generic;

namespace FactoryPlatform.Areas.ServiceNow.Models
{
    public class ItWorkOrdersModel
    {
        public List<Services_now_WorkOrders_Class> Services_now_WorkOrders_Class { get; set; } = new List<Services_now_WorkOrders_Class>();
        public List<Production_Stations> Production_Stations { get; set; } = new List<Production_Stations>();
        public List<Production_Departments> Production_Departments { get; set; } = new List<Production_Departments>();
        public List<Services_Factories> Services_Factories { get; set; } = new List<Services_Factories>();
        public List<ITSystems_HardwareReferences> ITSystems_HardwareReferences { get; set; } = new List<ITSystems_HardwareReferences>();

    }
}