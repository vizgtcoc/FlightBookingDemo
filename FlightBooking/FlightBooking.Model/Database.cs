using System;
using System.Collections.Generic;
using System.Text;

namespace FlightBooking.Model
{
    public class Database
    {
        public List<Flight> Flight { get; set; }
        public List<Hotel> Hotel { get; set; }


        public Database()
        {
            Flight = new List<Flight>
            {
                new Flight
                {
                    Id = 1,
                    BookedSeats = 5,
                    Destination = "London",
                    Source = "Coimbatore",
                    TotalSeats = 10
                },
                new Flight
                {
                    Id = 2,
                    BookedSeats = 5,
                    Destination = "Banglore",
                    Source = "Mumbai",
                    TotalSeats = 10
                },
                new Flight
                {
                    Id = 3,
                    BookedSeats = 5,
                    Destination = "London",
                    Source = "NewYork",
                    TotalSeats = 10
                }
            };

            Hotel = new List<Hotel>
            {
                new Hotel
                {
                    Id = 1,
                    City = "London",
                    BookedRooms = 5,
                    TotalRooms = 10
                },
                new Hotel
                {
                    Id = 2,
                    City = "Banglore",
                    BookedRooms = 5,
                    TotalRooms = 10
                },
                new Hotel
                {
                    Id = 3,
                    City = "Mumbai",
                    BookedRooms = 5,
                    TotalRooms = 10
                },
                new Hotel
                {
                    Id = 4,
                    City = "NewYork",
                    BookedRooms = 5,
                    TotalRooms = 10
                }
            };
        }
    }
}
