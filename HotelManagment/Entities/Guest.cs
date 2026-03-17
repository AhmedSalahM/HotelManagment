using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HotelManagment.Entities
{
    public enum Gender
    {
        Male,
        Female
    }
    internal class Guest
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Phone]
        public string Phone { get; set; }
        public Gender Gender { get; set; }

        public DateTime DateOfBirth { get; set; }

        public List<Reservation> Reservations { get; set; }
        public override string ToString()
        {

            return $"{Name}";
        }
    }
}
