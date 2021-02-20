using FlightBookings.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooking.Service.Interface
{
    public interface IBookingService
    {
        Task<BookingResultDto> BookFlights(BookingDto bookingDto);
    }
}
