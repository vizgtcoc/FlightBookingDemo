using System;
using System.Collections.Generic;
using System.Text;

namespace FlightBookings.Dto
{
    public class BookingDto
    {
        public int FlightId { get; set; }
        public int? TicketCount { get; set; }
        public int? HotelId { get; set; }
        public int? RoomCount { get; set; }
    }
    public class BookingResultDto
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
    }
}
