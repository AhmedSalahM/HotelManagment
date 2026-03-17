using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HotelManagment.Entities
{
    internal class Reservation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public DateTime CheckIn { get; set; }

        [Required]
        public DateTime CheckOut { get; set; }

        [ForeignKey("Guest")]
        public int GuestId { get; set; }

        public Guest Guest { get; set; }

        [ForeignKey("Room")]
        public int RoomId { get; set; }

        public Room Room { get; set; }
        public bool HasFood { get; set; }
        public override string ToString()
        {
            return $"Reservation #{Id} |  CheckIn: {CheckIn:d} | CheckOut: {CheckOut:d}|Guest: {Guest?.Name} | Room: {Room?.RoomNumber} |";
        }
        public string ReservationInfo
        {
            get
            {
                return $"#{Id}- {Guest?.Name} - Room {Room?.RoomNumber} ({CheckIn.ToShortDateString()} -> {CheckOut.ToShortDateString()}) {(HasFood ? "[Food]" : "")}";
            }
        }
    }
}
