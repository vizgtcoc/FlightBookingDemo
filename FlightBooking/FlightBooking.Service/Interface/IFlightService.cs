using FlightBooking.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooking.Service.Interface
{
    public interface IFlightService
    {
        Task<Flight> AddFlight(Flight flight);
        Task<IEnumerable<Flight>> GetFlights(string source = null, string destination = null);
        Task<Flight> GetFlight(int Id);


    }
}
