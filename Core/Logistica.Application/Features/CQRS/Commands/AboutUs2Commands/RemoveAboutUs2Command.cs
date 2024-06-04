using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.Features.CQRS.Commands.AboutUs2Commands
{
    public class RemoveAboutUs2Command
    {
        public int Id { get; set; }
        public RemoveAboutUs2Command(int id)
        {
            Id = id;
        }
    }
}
