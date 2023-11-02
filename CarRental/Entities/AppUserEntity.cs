using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Entities
{
    public class AppUserEntity
    {
        public int Id { get; set; }
        [StringLength(30)]
        public string Name { get; set; } = null!;
        [StringLength(100)]
        public string Password { get; set; } = null!;
        public AppUserRole Role { get; set; } = AppUserRole.Staff;
        public bool IsLocked { get; set; } = false;
    }
}
