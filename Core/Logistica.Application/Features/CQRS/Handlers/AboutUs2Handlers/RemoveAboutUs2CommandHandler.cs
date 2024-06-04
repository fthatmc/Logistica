using Logistica.Application.Features.CQRS.Commands.AboutUs2Commands;
using Logistica.Application.Features.CQRS.Commands.AboutUsCommands;
using Logistica.Application.Interfaces;
using Logistica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.Features.CQRS.Handlers.AboutUs2Handlers
{
    public class RemoveAboutUs2CommandHandler
    {
        private readonly IRepository<AboutUs2> _repository;

        public RemoveAboutUs2CommandHandler(IRepository<AboutUs2> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAboutUs2Command command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
