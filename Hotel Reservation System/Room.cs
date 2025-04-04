using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
    // Base class of the rooms: Standard and Deluxe rooms
    internal abstract class Room
    {
        // Room properties with getters and setters

        private int _roomNumber;
        private double _price;
        public bool IsReserved { get; protected set; }
        public string RoomType { get; protected set; }

      public int RoomNumber
        {
            get => _roomNumber;
            set
            {
                _roomNumber = value > 0 ? value : throw new ArgumentException("Room number must be positive");
            }
        }

        public double Price
        {
            get => _price;
            set
            {
                _price = value > 0 ? value : throw new ArgumentException("Price must be positive");
            }
        }

        // Constructor
        protected Room(int roomNumber, double price)
        {
            RoomNumber = roomNumber;
            Price = price;
            IsReserved = false;
        }

        // Abstract method to be overriden by derived classes
        public abstract void DisplayRoomInfo();

        // If IsReserved is false, change value to true
        public void MakeReservation()
        {
            if(IsReserved)
            {
                Console.WriteLine($"Room {RoomNumber} is already reserved.");
                return;
            }
            IsReserved = true;
            Console.WriteLine($"\n//***Reservation made for Room {RoomNumber}***//");
        }

        // If IsReserved is true, change value to false
        public void CancelReservation()
        {
            if(IsReserved)
            {
                IsReserved = false;
                Console.WriteLine($"//---Reservation canceled for Room {RoomNumber}---//");
                return;
            }
            Console.WriteLine($"Room {RoomNumber} is not currently reserved.");
        }
    }
}
