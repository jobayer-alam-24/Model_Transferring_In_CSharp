using System;
using Practice_Properties.models;
using Practice_Properties.transfer_models;

namespace Practice_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer JohnDoe = new Customer("R12345", "C98765", "John Doe", "Doe Enterprises", "555-1234", "john.doe@example.com", "123 Main St", "New York", "NY", 10001, "USA");
            Staff rahim = new Staff("S123", "John", "Doe", "jdoe", "password123", "Admin");
            Room room1 = new Room("R123", "Golden Butterfly", "5 Peoples", 30, 40);

            //Reservation Model Object
            Reservation_Model reservation_Model = new Reservation_Model()
            {
                ReservationID = "RE123",
                RefferredBy = "Maternal Uncles",
                StaffID = "S123",
                CustomerID = "C98765",
                RoomID = "R1234",
                ArrivalDate = DateTime.Now,
                DepartureDate = new DateTime(2024, 10, 20),
                PAX = 5
            };
            Reservation reservation1 = new Reservation(reservation_Model);

            JohnDoe.GetCustomerDetails();
            rahim.PrintStaffInfo();
            room1.RoomDetails();
            reservation1.ReservationDetails();
        }
    }
}