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
    public class FlightsController : ControllerBase
    {
        private readonly IFlightService _flightService;

        public FlightsController(IFlightService flightService)
        {
            this._flightService = flightService;
        }

        [HttpGet]
        public async Task<IActionResult> Get(string source = null, string destination = null)
        {
            return Ok(_flightService.GetFlights(source, destination));
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            return Ok(_flightService.GetFlight(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(Flight flight)
        {
            return Ok(_flightService.AddFlight(flight));
        }

        //// PUT api/<FlightsController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<FlightsController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
