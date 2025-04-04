﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
    // Manages rooms
    internal class Hotel
    {
        // Array of 5 rooms
        private Room[] _rooms = new Room[5];
        
        public Hotel()
        {
            InitializeRooms();
        }

        // Create 5 rooms
        private void InitializeRooms()
        {
            try
            {
                _rooms[0] = new StandardRoom(101, 1500, true);
                _rooms[1] = new StandardRoom(102, 1500, true);
                _rooms[2] = new StandardRoom(103, 1100, false);
                _rooms[3] = new DeluxeRoom(201, 2250, true, false);
                _rooms[4] = new DeluxeRoom(202, 2750, true, true);
            } catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
        }

        public void DisplayAllRooms()
        {
            Console.WriteLine($"\n --- Room List ---");
            foreach(Room room in _rooms)
            {
                room.DisplayRoomInfo();
            }
            Console.WriteLine("Press enter to continue");
            Console.ReadKey();
        }

        // return room if roomNumber is found
        public Room FindRoom(int roomNumber)
        {
            foreach (Room room in _rooms)
            {
                if(room.RoomNumber == roomNumber)
                {
                    return room;
                }
            }
            return null;
        }

    }
}

