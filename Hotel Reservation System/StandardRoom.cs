using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
    internal class StandardRoom : Room
    {
        // Standard Room properties with getters and setters

        public bool HasWifi { get; private set; }

        public StandardRoom(int roomNumber, double price, bool hasWifi) : base (roomNumber, price)
        {
            RoomType = "Standard Room";
            HasWifi = hasWifi;
        } 

        public override void DisplayRoomInfo()
        {
            Console.WriteLine($"Room {RoomNumber} - {RoomType}");
            Console.WriteLine($"Price per night: PHP{Price}");
            Console.WriteLine($"Status: {(IsReserved ? "Reserved" : "Available")}");
            Console.WriteLine($"Amenities: {(HasWifi ? "Wifi included" : "No wifi")}");
            Console.WriteLine();
        }
    }
}

