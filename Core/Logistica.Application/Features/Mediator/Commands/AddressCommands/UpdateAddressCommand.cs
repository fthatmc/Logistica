using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.Features.Mediator.Commands.AddressCommands
{
    public class UpdateAddressCommand : IRequest
    {
        public int AddressId { get; set; }
        public string Location { get; set; }
        public string Call { get; set; }
        public string Email { get; set; }
    }
}
