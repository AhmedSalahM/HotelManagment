using HotelManagment.Entities;

namespace HotelManagment
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            using (var context = new HotelDbContext())
            {
                if (!context.Users.Any())
                {
                    User admin = new User
                    {
                        Username = "admin",
                        Password = "123",
                        Role = UserRole.Reservation
                    };
                    context.Users.Add(admin);
                    context.SaveChanges();

                }
                if (!context.Users.Any(u => u.Username == "kitchen"))
                {
                    User kitchenUser = new User
                    {
                        Username = "kitchen",
                        Password = "123", 
                        Role = UserRole.Kitchen
                    };
                    context.Users.Add(kitchenUser);
                    context.SaveChanges();
                }
                // ===== Guests =====
                if (!context.Guests.Any())
                {
                    context.Guests.Add(new Guest { Name = "Ahmed Ali", Phone = "01012345678" });
                    context.Guests.Add(new Guest { Name = "Sara Mohamed", Phone = "01123456789" });
                    context.Guests.Add(new Guest { Name = "Omar Hassan", Phone = "01234567890" });
                    context.SaveChanges();
                }

                // ===== Rooms =====
                if (!context.Rooms.Any())
                {
                    for (int i = 1; i <= 10; i++)
                    {
                        context.Rooms.Add(new Room
                        {
                            RoomNumber = 100 + i,
                            Price = 500 + i * 50,
                            IsAvailable = true
                        });
                    }
                    context.SaveChanges();
                }
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}