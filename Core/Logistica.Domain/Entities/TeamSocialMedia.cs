﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Domain.Entities
{
    public class TeamSocialMedia
    {
        public int TeamSocialMediaId { get; set; }
        public string Url { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public int TeamId { get; set; }
        public Team Team { get; set; }
    }
}
