using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Domain.Entities
{
    public class Address
    {
        public int AddressId { get; set; }
        public string Location { get; set; }
        public string Call { get; set; }
        public string Email { get; set; }
    }
}
