using Logistica.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Persistence.Repositories
{
    public class AboutUsRepository
    {
        private readonly LogisticaContext _context;

        public AboutUsRepository(LogisticaContext context)
        {
            _context = context;
        }
    }
}
