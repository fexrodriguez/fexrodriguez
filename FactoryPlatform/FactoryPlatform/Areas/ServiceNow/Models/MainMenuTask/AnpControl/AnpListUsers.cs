﻿using System.ComponentModel.DataAnnotations;

namespace FactoryPlatform.Areas.ServiceNow.Models.MainMenuTask.AnpControl
{
    public class AnpListUsers
    {
        [Key]
        public int? ID { get; set; }
        public string? Text { get; set; }
    }
}