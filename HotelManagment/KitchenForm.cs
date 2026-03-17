using HotelManagment.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelManagment
{
    public partial class KitchenForm : Form
    {
        HotelDbContext context;
        BindingList<Reservation> foodReservations;
        public KitchenForm()
        {
            InitializeComponent();
            context = new HotelDbContext();

            LoadFoodReservations();
        }
        private void LoadFoodReservations()
        {

            context.Reservations.Include(r => r.Guest)
                                .Include(r => r.Room)
                                .Load();


            var filtered = context.Reservations.Local
                           .Where(r => r.HasFood)
                           .ToList();

            foodReservations = new BindingList<Reservation>(filtered);

            lstFoodReservations.DataSource = foodReservations;
            lstFoodReservations.DisplayMember = "ReservationInfo";
            lstFoodReservations.ValueMember = "Id";
        }
        private void KitchenForm_Load(object sender, EventArgs e)
        {

        }

        private void btnMarkServed_Click(object sender, EventArgs e)
        {
            if (lstFoodReservations.SelectedItem == null) return;

            Reservation res = lstFoodReservations.SelectedItem as Reservation;


            //res.HasFood = false;
            //context.SaveChanges();


            foodReservations.Remove(res);

        }

        private void button2_Click(object sender, EventArgs e)
        {
           LoadFoodReservations();
        }
    }
}
