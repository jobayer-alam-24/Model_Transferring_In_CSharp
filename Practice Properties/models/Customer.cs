using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Properties.models
{
    public class Customer
    {
        private readonly string ReservationID;
        private readonly string CustomerID;
        private string Name;
        private string Company;
        private string Phone;
        private string Email;
        private string Address;
        private string City;
        private string State;
        private int PostalCode;
        private string Country;
        private Type type = new Type("CRT12345");

        public Customer(string reservationID, string customerID, string name, string company, string phone, string email, string address, string city, string state, int postalCode, string country)
        {
            ReservationID = reservationID;
            CustomerID = customerID;
            Name = name;
            Company = company;
            Phone = phone;
            Email = email;
            Address = address;
            City = city;
            State = state;
            PostalCode = postalCode;
            Country = country;
        }
        public void GetCustomerDetails()
        {
            Console.WriteLine($"=======Customer Details========");
            Console.WriteLine($"Customer ID: {CustomerID}");
            Console.WriteLine($"Reservation Type: {type.TypeName}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Company: {Company}");
            Console.WriteLine($"Phone Number: {Phone}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Address: {Address}");
            Console.WriteLine($"City: {City}");
            Console.WriteLine($"State: {State}");
            Console.WriteLine($"Postal Code: {PostalCode}");
            Console.WriteLine($"Country: {Country}");
        }
    }
}