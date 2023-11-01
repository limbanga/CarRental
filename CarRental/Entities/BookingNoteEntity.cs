using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities
{
    public class BookingNoteEntity
    {
        public int Id { get; set; }
        public int? CustomerId { get; set; }
        public CustomerEntity? Customer { get; set; }
        public int? CarId { get; set; }
        public CarEntity? Car { get; set; }
        public float TotalFee { get; set; } = 0;
        public DateTime RentAt { get; set; } = DateTime.Now;
        public DateTime ReturnAt { get; set; } = DateTime.Now;
        public DateTime RealReturnAt { get; set; } = DateTime.MaxValue;
        [StringLength(200)]
        public string Departure { get; set; } = null!;
        [StringLength(200)]
        public string Destination { get; set; } = null!;
        public string UserName => Customer == null? "-": Customer.Name;
        public string CarName => Car == null ? "-" : $"{Car.CarName} {Car.CarType} {Car.NameCode}";
        public string GetRealReturnedAt => IsReturn ? RealReturnAt.ToString("dd/MM/yyyy"): "Not yet";
        public bool IsReturn => RealReturnAt.Year != DateTime.MaxValue.Year;
    }
}
