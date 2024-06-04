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
    public class CreateAboutUs2CommandHandler
    {
        private readonly IRepository<AboutUs2> _repository;

        public CreateAboutUs2CommandHandler(IRepository<AboutUs2> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAboutUs2Command command)
        {
            await _repository.CreateAsync(new AboutUs2
            {
                Title = command.Title,
                Description = command.Description,
                Icon = command.Icon
            });
        }
    }
}
