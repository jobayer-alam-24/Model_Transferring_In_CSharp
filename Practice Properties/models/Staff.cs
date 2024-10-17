using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Properties.models
{
    public class Staff
    {
        private readonly string StaffID;
        private const string StaffsEducationLevel = "BSC IN CSE (Just For Fun)";
        private string FirstName;
        private string LastName;
        private string UserName;
        private string Password;
        private string AccessLevel;

        public Staff(string StaffID, string FirstName, string LastName, string UserName, string Password, string AccessLevel)
        {
            this.StaffID = StaffID;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.UserName = UserName;
            this.Password = Password;
            this.AccessLevel = AccessLevel;
        }
        public void PrintStaffInfo()
        {
            Console.WriteLine($"=========Staff Information========");
            Console.WriteLine($"Staff ID: {StaffID}");
            Console.WriteLine($"Education Level (At Least): {StaffsEducationLevel}");
            Console.WriteLine($"First Name: {FirstName}");
            Console.WriteLine($"Last Name: {LastName}");
            Console.WriteLine($"User Name: {UserName}");
            Console.WriteLine($"Password: {Password.GetHashCode()}");
            Console.WriteLine($"Access Level: {AccessLevel}");
        }
    }
}