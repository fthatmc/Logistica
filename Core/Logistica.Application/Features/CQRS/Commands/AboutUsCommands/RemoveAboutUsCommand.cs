using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.Features.CQRS.Commands.AboutUsCommands
{
    public class RemoveAboutUsCommand
    {
        public int Id { get; set; }
        public RemoveAboutUsCommand(int id)
        {
            Id = id;
        }
    }
}
