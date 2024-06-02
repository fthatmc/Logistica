using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logistica.Domain.Entities
{
    public class Card
    {
        public int CardId { get; set; }
        public string Title { get; set; }
        public int Count  { get; set; }
        public string Icon  { get; set; }
        public string Color  { get; set; }
    }
}
