using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Reservation_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Welcome to Felicity Hotel ===");
            Hotel hotel = new Hotel();
            while (true)
            {
                Console.WriteLine("\nMain Menu:");
                Console.WriteLine("1. View all rooms");
                Console.WriteLine("2. Make a reservation");
                Console.WriteLine("3. Cancel a reservation");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");
                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            hotel.DisplayAllRooms();
                            break;
                        case 2:
                            MakeReservation(hotel);
                            break;
                        case 3:
                            CancelReservation(hotel);
                            break;
                        case 4:
                            Console.WriteLine("\nThank you for using the Felicity Hotel Reservation System!");
                            return;
                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter a valid number.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
                Console.WriteLine("===========================================");
            }
        }
        static void MakeReservation(Hotel hotel)
        {
            Console.Write("\nEnter room number to reserve: ");

            if (int.TryParse(Console.ReadLine(), out int roomNumber))
            {
                Room room = hotel.FindRoom(roomNumber);
                if (room != null)
                {
                    room.MakeReservation();
                }
                else
                {
                    Console.WriteLine("Room not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid room number.");
            }
        }
        static void CancelReservation(Hotel hotel)
        {
            Console.Write("\nEnter room number to cancel reservation: ");
            if(int.TryParse(Console.ReadLine(), out int roomNumber))
            {
                Room room = hotel.FindRoom(roomNumber);
                if(room != null)
                {
                    room.CancelReservation();
                }
                else
                {
                    Console.WriteLine("Room not found.");
                }
            }
            else
            {
                Console.WriteLine("Invalid room number.");
            }
        }
    }
}
