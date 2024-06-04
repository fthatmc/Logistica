using Logistica.Application.Features.CQRS.Results.AboutUs2Results;
using Logistica.Application.Features.CQRS.Results.AboutUsResults;
using Logistica.Application.Interfaces;
using Logistica.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.Features.CQRS.Handlers.AboutUs2Handlers
{
    public class GetAboutUs2QueryHandler
    {
        private readonly IRepository<AboutUs2> _repository;

        public GetAboutUs2QueryHandler(IRepository<AboutUs2> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAboutUs2QueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAboutUs2QueryResult
            {
                AboutUs2Id = x.AboutUs2Id,
                Icon = x.Icon,
                Description = x.Description,
                Title = x.Title
            }).ToList();
        }
    }
}
