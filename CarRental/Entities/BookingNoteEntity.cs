using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities
{
    public class BookingNoteEntity
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public AppUserEntity? User { get; set; }
        public int? CarId { get; set; }
        public CarEntity? Car { get; set; }
        public DateTime RentAt { get; set; } = DateTime.Now;
        public DateTime ReturnAt { get; set; } = DateTime.Now;
        public DateTime RealReturnAt { get; set; } = DateTime.Now;

        //public int TimeRent { get; set; }
    }
}
