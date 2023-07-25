﻿using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace FactoryPlatform.Data
{
    public partial class EngineeringCustomerVoiceQuestionsLog
    {
        public int IdRegistro { get; set; }
        public DateTime FechaRegistro { get; set; }
        public int UsuarioRegistro { get; set; }
        public string QuestionPrevious { get; set; }
        public string QuestionNew { get; set; }
        public int QuestionId { get; set; }
        public bool? Disabled { get; set; }
    }
}