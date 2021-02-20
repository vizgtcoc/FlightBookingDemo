using FlightBooking.Model;
using FlightBooking.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FlightBooking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelService _hotelService;

        public HotelController(IHotelService hotelService)
        {
            this._hotelService = hotelService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(_hotelService.GetHotels());
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(_hotelService.GetHotel(id));
        }


        [HttpPost]
        public async Task<IActionResult> Post(Hotel hotel)
        {
            return Ok(_hotelService.AddHotel(hotel));
        }

        // PUT api/<HotelController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<HotelController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
