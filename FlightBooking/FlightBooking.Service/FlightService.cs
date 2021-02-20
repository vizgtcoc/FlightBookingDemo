using FlightBooking.Model;
using FlightBooking.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooking.Service
{
    public class FlightService : IFlightService
    {
        private readonly Database _database;

        public FlightService(Database database)
        {
            this._database = database;
        }
        public async Task<Flight> AddFlight(Flight flight)
        {
            flight.Id = _database.Flight.Max(x => x.Id) + 1;
            _database.Flight.Add(flight);
            return flight;
        }

        public async Task<Flight> GetFlight(int Id)
        {
            return _database.Flight.Where(x => x.Id == Id).FirstOrDefault();
        }

        public async Task<IEnumerable<Flight>> GetFlights(string source = null, string destination = null)
        {
            if (!string.IsNullOrEmpty(source) && !string.IsNullOrEmpty(destination))
            {
                return _database.Flight.Where(x => x.Source.Equals(source, StringComparison.OrdinalIgnoreCase) && x.Destination.Equals(destination, StringComparison.OrdinalIgnoreCase));
            }

            return _database.Flight;
        }
    }
}
