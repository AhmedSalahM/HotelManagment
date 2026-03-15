using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelManagment
{
    internal class Room
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int RoomNumber { get; set; }

        [Required]
        public decimal Price { get; set; }

        public bool IsAvailable { get; set; }

        public List<Reservation> Reservations { get; set; }
    }
}
