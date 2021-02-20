using FlightBooking.Service.Interface;
using FlightBookings.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlightBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingsController : ControllerBase
    {
        private readonly IBookingService _bookingService;

        public BookingsController(IBookingService bookingService)
        {
            this._bookingService = bookingService;
        }
        [HttpPost]
        public async Task<IActionResult> Post(BookingDto booking)
        {
            return Ok(_bookingService.BookFlights(booking));
        }
    }
}
