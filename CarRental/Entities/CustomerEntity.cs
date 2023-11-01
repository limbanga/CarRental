using ClosedXML.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities
{
    public class CustomerEntity
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; } = null!;
        [StringLength(15)]
        public string PhoneNumber { get; set; } = null!;
        [StringLength(200)]
        public string Address { get; set; } = null!;

        [XLColumn(Ignore = true)]
        public string ComboboxDisplay => $"{PhoneNumber} - {Name}";

    }
}
