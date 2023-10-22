using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities
{
    public class CustomerEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Address { get; set; } = null!;

        public string ComboboxDisplay => $"{PhoneNumber}-{Name}";

    }
}
