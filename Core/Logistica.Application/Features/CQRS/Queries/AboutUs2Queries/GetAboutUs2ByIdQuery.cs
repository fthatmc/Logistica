using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Application.Features.CQRS.Queries.AboutUs2Queries
{
    public class GetAboutUs2ByIdQuery
    {
        public int Id { get; set; }
        public GetAboutUs2ByIdQuery(int id)
        {
            Id = id;
        }
    }
}
