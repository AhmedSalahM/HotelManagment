using HotelManagment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagment
{
    internal class HotelDbContext:DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Guest> Guests { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(
                "Server=DESKTOP-5G9P0QP\\SQLEXPRESS;Database=HotelSystemDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
