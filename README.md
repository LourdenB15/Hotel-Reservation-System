# Hotel Reservation System

## Overview
This is a console-based Hotel Reservation System application built with C# that demonstrates the four fundamental Object-Oriented Programming (OOP) principles: Encapsulation, Inheritance, Polymorphism, and Abstraction.

## Features
- Room management (Standard and Deluxe rooms)
- Make and cancel reservations
- View all available rooms
- Input validation and error handling

## OOP Principles Demonstrated

### ✅ Encapsulation
- Private fields with public getters/setters
- Validation in property setters
- Protected access modifiers where appropriate

### ✅ Inheritance
- Base `Room` class
- Derived `StandardRoom` and `DeluxeRoom` classes
- Shared properties and methods in base class

### ✅ Polymorphism
- Method overriding (`DisplayRoomInfo`)
- Runtime polymorphism through base class references

### ✅ Abstraction
- Abstract `Room` class with abstract method
- Implementation details hidden in derived classes

## Installation & Setup
1. Clone the repository or download the ZIP file.
2. Open the project in Visual Studio or any C# IDE.
3. Build the project to restore dependencies.
4. Run the project to start the console application.
5. Follow the on-screen prompts.
6. Enjoy the application.

## How to Run

1. **Prerequisites**:
   - .NET SDK installed (version 6.0 or higher recommended)

2. **Running the Application**:

   ```bash
   dotnet run
   ```

3. **Using the Application**:
  - Main menu provides options to:
    - View all rooms
    - Make a reservation
    - Cancel a reservation
    - Exit the system

## Example Usage
1. View all rooms to see availability and prices
2. Select a room to make a reservation
3. Cancel reservations when needed

## Error Handling
The application includes comprehensive error handling for:
- Invalid menu choices
- Invalid room numbers
- Invalid input formats
