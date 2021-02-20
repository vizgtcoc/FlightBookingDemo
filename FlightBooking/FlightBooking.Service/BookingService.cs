using FlightBooking.Model;
using FlightBooking.Service.Interface;
using FlightBookings.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooking.Service
{
    public class BookingService : IBookingService
    {
        private readonly Database _database;

        public BookingService(Database database)
        {
            this._database = database;
        }
        public async Task<BookingResultDto> BookFlights(BookingDto bookingDto)
        {

            BookingResultDto bookingResultDto = new BookingResultDto();

            var flight = _database.Flight.Where(x => x.Id == bookingDto.FlightId).FirstOrDefault();


            if (flight == null)
            {
                bookingResultDto.ErrorMessage = "Invalid FlightId";
                return bookingResultDto;
            }
            var availableTickets = flight.TotalSeats - flight.BookedSeats;
            if (!bookingDto.TicketCount.HasValue || bookingDto.TicketCount.Value <= 0)
            {
                bookingDto.TicketCount = 1;
            }

            if (bookingDto.TicketCount.Value > availableTickets)
            {
                bookingResultDto.ErrorMessage = "Tickets not available";
                return bookingResultDto;
            }

            Hotel hotel;
            int availableRooms = 0;
            if (bookingDto.HotelId.HasValue && bookingDto.HotelId.Value > 0)
            {
                hotel = _database.Hotel.Where(x => x.Id == bookingDto.HotelId.Value).FirstOrDefault();
                if (hotel == null)
                {
                    bookingResultDto.ErrorMessage = "Invalid HotelId";
                    return bookingResultDto;
                }
                availableRooms = hotel.TotalRooms - hotel.BookedRooms;

                if (!bookingDto.RoomCount.HasValue || bookingDto.RoomCount.Value <= 0)
                {
                    bookingDto.RoomCount = 1;
                }

                if (bookingDto.RoomCount.Value > availableRooms)
                {
                    bookingResultDto.ErrorMessage = "Rooms not available";
                    return bookingResultDto;
                }

                //DB Update
                _database.Hotel.Remove(hotel);
                hotel.BookedRooms += bookingDto.RoomCount.Value;
                _database.Hotel.Insert(hotel.Id - 1, hotel);

            }

            //DB Update
            _database.Flight.Remove(flight);
            flight.BookedSeats += bookingDto.TicketCount.Value;
            _database.Flight.Insert(flight.Id - 1, flight);

            bookingResultDto.IsSuccess = true;
            return bookingResultDto;


        }
    }
}
