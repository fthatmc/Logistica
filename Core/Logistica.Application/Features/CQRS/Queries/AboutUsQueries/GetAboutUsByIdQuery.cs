using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.Features.CQRS.Queries.AboutUsQueries
{
    public class GetAboutUsByIdQuery
    {
        public GetAboutUsByIdQuery(int id)
        {
            Id = id;
        }
        public int Id { get; set; }
    }
}
