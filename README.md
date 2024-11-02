# Hotel Booking System

## Overview
This Hotel Booking System is a demonstration of my ability to develop applications in C# using the .NET Framework on Visual Studio 2022. The system models a hotel with dynamic room pricing based on the season and time of year, while allowing receptionists to manage reservations through a user-friendly interface. The project showcases the following core functionalities:
- CRUD operations on a service-based database using SQL.
- Report generation based on database data.
- Use of a three-layered architecture approach for scalability and maintainability.

## Features

### Room Management
- The hotel offers 4 different room types with dynamic pricing based on the season.
- Prices fluctuate depending on the time of year (e.g., peak season vs. off-season).

### Reservation Management
- Receptionists can create, update, and cancel reservations based on customer requests.
- Upon creating a reservation, a booking confirmation and unique reservation number are provided to the client.

### CRUD Operations
- The system interacts with a service-based SQL database to perform Create, Read, Update, and Delete (CRUD) operations on reservations and other hotel-related data.
- Dynamic updates to the database occur whenever changes are made to reservations, ensuring the latest data is reflected.

### Report Generation
- The system generates reports using data stored in the SQL database.
- Reports are used to provide insights into booking trends, occupancy, and revenue based on room types and seasons.

## Three-Layered Architecture
The system is designed following a three-layered architecture:
- **Presentation Layer**: Handles the user interface (Windows Forms) for receptionists to interact with.
- **Business Logic Layer (BLL)**: Contains the logic for managing reservations, dynamic pricing, and validation.
- **Data Access Layer (DAL)**: Manages communication with the SQL database to perform CRUD operations.

## Use Cases

### Receptionist Reservation Flow
The system allows a receptionist to:
- Check room availability.
- Make a reservation for a client.
- Provide booking confirmation and generate a unique reservation number.

### Dynamic Pricing
Room prices adjust automatically based on predefined seasonal rules.

### Database Management
The receptionist can edit or delete reservations as needed, with all changes reflected in real-time in the SQL database.

## Technology Stack
- C# (.NET Framework)
- Visual Studio 2022
- SQL Server (Service-based database)
- Windows Forms (for the user interface)

## Conclusion
This project is a comprehensive demonstration of my ability to develop enterprise-grade applications in C# using the .NET framework, perform database management through SQL, and design systems with a three-layered architecture. The Hotel Booking System effectively handles dynamic business logic while ensuring data consistency and scalability.
