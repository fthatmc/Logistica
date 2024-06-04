using Logistica.Application.Features.CQRS.Queries.AboutUs2Queries;
using Logistica.Application.Features.CQRS.Results.AboutUs2Results;
using Logistica.Application.Interfaces;
using Logistica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.Features.CQRS.Handlers.AboutUs2Handlers
{
    public class GetAboutUs2ByIdQueryHandler
    {
        private readonly IRepository<AboutUs2> _repository;

        public GetAboutUs2ByIdQueryHandler(IRepository<AboutUs2> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutUs2ByIdQueryResult> Handle(GetAboutUs2ByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAboutUs2ByIdQueryResult
            {
                AboutUs2Id = values.AboutUs2Id,
                Description = values.Description,
                Title = values.Title,
                Icon = values.Icon
            };
        }
    }
}
