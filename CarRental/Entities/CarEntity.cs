using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities
{
    public class CarEntity
    {
        public int Id { get; set; }
        public string NameCode { get; set; } = null!;
        public CarType CarType { get; set; }
        public string Brand { get; set; } = null!;

    }
}
