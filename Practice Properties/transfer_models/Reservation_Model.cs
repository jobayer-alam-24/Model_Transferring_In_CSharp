using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Properties.transfer_models
{
    public class Reservation_Model
    {
        public string ReservationID;
        public string RefferredBy;
        public string StaffID;
        public string CustomerID;
        public string RoomID;
        public DateTime ArrivalDate;  
        public DateTime DepartureDate;

        //PAX = Number of Person('s) or Peoples staying in a Room..
        public int PAX;
    }
}