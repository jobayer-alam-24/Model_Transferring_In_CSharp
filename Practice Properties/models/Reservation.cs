using System;
using System.Collections.Generic;
using System.Formats.Tar;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Practice_Properties.transfer_models;

namespace Practice_Properties.models
{
    public class Reservation
    {
        private readonly string ReservationID;
        private string RefferredBy;
        private readonly string StaffID;
        private readonly string CustomerID;
        private readonly string RoomID;
        private DateTime ArrivalDate;  
        private DateTime DepartureDate;

        //PAX = Number of Person('s) or Peoples staying in a Room..
        private int PAX;
        private Type type = new Type(null);  

        //Receiving An object OF Reservation Model..
        public Reservation(Reservation_Model res)
        {
            ReservationID = res.ReservationID;
            RefferredBy = res.RefferredBy;
            CustomerID = res.CustomerID;
            RoomID = res.RoomID;
            StaffID = res.StaffID;
            ArrivalDate = res.ArrivalDate;
            DepartureDate = res.DepartureDate;
            PAX = res.PAX;
        }
        public void ReservationDetails()
        {
            Console.WriteLine($"=======Reservation Information=======");
            Console.WriteLine($"Reservation Id: {ReservationID}");
            Console.WriteLine($"Reservation Type: {type.TypeName}");
            Console.WriteLine($"Refferred By: {RefferredBy}");
            Console.WriteLine($"Staff Id: {StaffID}");
            Console.WriteLine($"Customer Id: {CustomerID}");
            Console.WriteLine($"Room Id: {RoomID}");
            Console.WriteLine($"Arrival Date: {ArrivalDate}");
            Console.WriteLine($"Departure Date: {DepartureDate}");
            Console.WriteLine($"Pax (Number of Peoples Staying in a room): {PAX}");
        }
    }
}