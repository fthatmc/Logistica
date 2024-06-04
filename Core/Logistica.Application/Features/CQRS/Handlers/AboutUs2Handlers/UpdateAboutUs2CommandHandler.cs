using Logistica.Application.Features.CQRS.Commands.AboutUs2Commands;
using Logistica.Application.Interfaces;
using Logistica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.Features.CQRS.Handlers.AboutUs2Handlers
{
    public class UpdateAboutUs2CommandHandler
    {
        private readonly IRepository<AboutUs2> _repository;

        public UpdateAboutUs2CommandHandler(IRepository<AboutUs2> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAboutUs2Command command)
        {
            var values = await _repository.GetByIdAsync(command.AboutUs2Id);
            values.Description = command.Description;
            values.Title = command.Title;
            values.Icon = command.Icon;
            await _repository.UpdateAsync(values);
        }
    }
}
