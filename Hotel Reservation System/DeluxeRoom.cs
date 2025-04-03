using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
    internal class DeluxeRoom : Room
    {
        public bool HasBalcony { get; private set; }
        public bool HasMiniBar { get; private set; }

        public DeluxeRoom(int roomNumber, double price, bool hasBalcony, bool hasMiniBar) : base (roomNumber, price)
        {
            HasBalcony = hasBalcony;
            HasMiniBar = hasMiniBar;
            RoomType = "Deluxe Room";
        }

        public override void DisplayRoomInfo()
        {
            Console.WriteLine($"Room {RoomNumber} - {RoomType}");
            Console.WriteLine($"Price per night: PHP{Price}");
            Console.WriteLine($"Status: {(IsReserved ? "Reserved": "Available")}");
            if(HasBalcony && !HasMiniBar)
            {
                Console.WriteLine($"Amenities: Balcony");
            } else
            {
                Console.WriteLine($"Amenities: {(HasBalcony ? "Balcony, " : "")}{(HasMiniBar ? "Mini Bar" : "")}");
            }
            Console.WriteLine();
        }
    }
}
