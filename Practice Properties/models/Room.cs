using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Properties.models
{
    public class Room
    {
        private readonly string RoomID;
        private string RoomName;
        private string Capacity;
        private double Length;
        private double Width;
        private double Area; 

        public Room(string roomID, string roomName, string capacity, double length, double width)
        {
            RoomID = roomID;
            RoomName = roomName;
            Capacity = capacity;
            Length = length;
            Width = width;
            Area = Math.Round(Length * Width);
        }

        public void RoomDetails()
        {
            Console.WriteLine($"======Room Details======");
            Console.WriteLine($"Room ID: {RoomID}");
            Console.WriteLine($"Room Name: {RoomName}");
            Console.WriteLine($"Length: {Length} ft");
            Console.WriteLine($"Width: {Width} ft");
            Console.WriteLine($"Area of Room: {Area} Square Feet");
        }
    }
}