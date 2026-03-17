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
    public partial class ReservationForm : Form
    {
        HotelDbContext context;
        BindingList<Guest> guestBindingList;
        public ReservationForm()
        {
            InitializeComponent();
            context = new HotelDbContext();


            //comboBox1.DataSource = context.Guests.ToList();
            //comboBox1.DisplayMember = "Name";
            //comboBox1.ValueMember = "Id";


            comboBox2.DataSource = context.Rooms.ToList();
            comboBox2.DisplayMember = "RoomNumber";
            comboBox2.ValueMember = "Id";


            LoadGuests();
            LoadReservations();

            cmbGender.DataSource = Enum.GetValues(typeof(Gender));

        }
        private void LoadGuests()
        {
            context.Guests.Load();

            guestBindingList = context.Guests.Local.ToBindingList();

            lstGuests.DataSource = guestBindingList;
            comboBox1.DataSource = guestBindingList;
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }
        private void LoadAvailableRooms(DateTime checkIn, DateTime checkOut)
        {
            var availableRooms = context.Rooms
                .Where(room => !context.Reservations
                    .Any(r =>
                        r.RoomId == room.Id &&
                        ((checkIn >= r.CheckIn && checkIn < r.CheckOut) ||
                         (checkOut > r.CheckIn && checkOut <= r.CheckOut) ||
                         (checkIn <= r.CheckIn && checkOut >= r.CheckOut))
                    )
                ).ToList();

            comboBox2.DataSource = availableRooms;
            comboBox2.DisplayMember = "RoomNumber";
            comboBox2.ValueMember = "Id";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Guest and Room.");
                return;
            }

            int guestId = (int)comboBox1.SelectedValue;
            int roomId = (int)comboBox2.SelectedValue;
            DateTime checkIn = dateTimePicker1.Value;
            DateTime checkOut = dateTimePicker2.Value;


            bool roomOccupied = context.Reservations.Any(r =>
        r.RoomId == roomId &&
        ((checkIn >= r.CheckIn && checkIn < r.CheckOut) ||
         (checkOut > r.CheckIn && checkOut <= r.CheckOut) ||
         (checkIn <= r.CheckIn && checkOut >= r.CheckOut))
    );

            if (roomOccupied)
            {
                MessageBox.Show("This room is already reserved in the selected period.");

                return;
            }


            Reservation reservation = new Reservation
            {
                GuestId = guestId,
                RoomId = roomId,
                CheckIn = checkIn,
                CheckOut = checkOut,
                HasFood = checkBox1.Checked,
            };

            context.Reservations.Add(reservation);
            context.SaveChanges();

            MessageBox.Show("Reservation created successfully!");
            LoadReservations();







        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadAllReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var results = context.Reservations
         .Select(r => new
         {
             r.Id,
             GuestName = r.Guest.Name,
             GuestPhone = r.Guest.Phone,
             RoomNumber = r.Room.RoomNumber,
             RoomPrice = r.Room.Price,
             CheckIn = r.CheckIn,
             CheckOut = r.CheckOut,
             HasFood = r.HasFood

         }).ToList();
            dataGridView1.DataSource = results;

        }

        private void ReservationForm_Load(object sender, EventArgs e)
        {

        }

        private void loadReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            context.Reservations.Include(r => r.Guest).Load();
            dataGridView1.DataSource = context.Reservations.Local.ToBindingList();

        }

        private void loadGuestsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            context.Guests.Load();
            dataGridView1.DataSource = context.Guests.Local.ToBindingList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstGuests_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstGuests.SelectedItem == null) return;

            Guest guest = lstGuests.SelectedItem as Guest;

            txtName.Text = guest.Name;
            txtPhone.Text = guest.Phone;
            cmbGender.SelectedItem = guest.Gender;
            if (guest.DateOfBirth > dtpBirth.MinDate)
                dtpBirth.Value = guest.DateOfBirth;
            else
                dtpBirth.Value = DateTime.Today;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (lstGuests.SelectedItem == null) return;

            Guest guest = lstGuests.SelectedItem as Guest;

            context.Guests.Remove(guest);
            context.SaveChanges();

            LoadGuests();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lstGuests.SelectedItem == null) return;

            Guest guest = lstGuests.SelectedItem as Guest;

            guest.Name = txtName.Text;
            guest.Phone = txtPhone.Text;
            guest.Gender = (Gender)cmbGender.SelectedItem;
            guest.DateOfBirth = dtpBirth.Value;

            context.SaveChanges();

            LoadGuests();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Guest guest = new Guest
            {
                Name = txtName.Text,
                Phone = txtPhone.Text,
                Gender = (Gender)cmbGender.SelectedItem,
                DateOfBirth = dtpBirth.Value
            };

            context.Guests.Add(guest);
            context.SaveChanges();

            LoadGuests();
        }
        private void LoadReservations()
        {
            context.Reservations.Include(r => r.Guest).Include(r => r.Room).Load();
            listBox1.DataSource = context.Reservations.Local.ToBindingList();
            listBox1.DisplayMember = "ReservationInfo";
            listBox1.ValueMember = "Id";
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            Reservation res = listBox1.SelectedItem as Reservation;

            comboBox1.SelectedValue = res.GuestId;
            comboBox2.SelectedValue = res.RoomId;
            dateTimePicker1.Value = res.CheckIn;
            dateTimePicker2.Value = res.CheckOut;
            checkBox1.Checked = res.HasFood;

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            Reservation res = listBox1.SelectedItem as Reservation;

            res.GuestId = (int)comboBox1.SelectedValue;
            res.RoomId = (int)comboBox2.SelectedValue;
            res.CheckIn = dateTimePicker1.Value;
            res.CheckOut = dateTimePicker2.Value;
            res.HasFood = checkBox1.Checked;

            context.SaveChanges();
            LoadReservations();
            MessageBox.Show("Updated successfully!");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;

            Reservation res = listBox1.SelectedItem as Reservation;

            context.Reservations.Remove(res);
            context.SaveChanges();

            LoadReservations();

            MessageBox.Show("Deleted successfully!");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                MessageBox.Show("Please select a reservation.");
                return;
            }

            Reservation res = listBox1.SelectedItem as Reservation;

           
            int days = (res.CheckOut - res.CheckIn).Days;
            if (days == 0) days = 1; 

            decimal roomPrice = res.Room.Price * days;

            decimal foodPrice = 0;
            if (res.HasFood)
            {
                decimal pricePerFood = 4; 
                foodPrice = pricePerFood * days;
            }

            decimal total = roomPrice + foodPrice;

            MessageBox.Show($"Guest: {res.Guest.Name}\n" +
                            $"Room: {res.Room.RoomNumber}\n" +
                            $"Days: {days}\n" +
                            $"Room Price: {roomPrice:C}\n" +
                            $"Food Price: {foodPrice:C}\n" +
                            $"Total: {total:C}", "Bill");
        }
    }
}
