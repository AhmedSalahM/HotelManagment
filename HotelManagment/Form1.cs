using HotelManagment.Entities;

namespace HotelManagment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var context = new HotelDbContext())
            {
                var user = context.Users.FirstOrDefault(u =>
                    u.Username == textBox1.Text &&
                    u.Password == textBox2.Text);

                if (user != null)
                {
                    MessageBox.Show("Login Success");

                    if (user.Role == UserRole.Kitchen)
                        new KitchenForm().Show();
                    else if (user.Role == UserRole.Reservation)
                        new ReservationForm().Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }

        }
    }
}
