using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Domain.Entities
{
    public class Team
    {
        public int TeamId { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
        public List<TeamSocialMedia> TeamSocialMedias { get; set; }
    }
}
