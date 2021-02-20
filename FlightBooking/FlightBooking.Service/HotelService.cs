using FlightBooking.Model;
using FlightBooking.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooking.Service
{
    public class HotelService : IHotelService
    {
        private readonly Database _database;

        public HotelService(Database database)
        {
            this._database = database;
        }
        public async Task<Hotel> AddHotel(Hotel hotel)
        {
            hotel.Id = _database.Hotel.Max(x => x.Id) + 1;
            _database.Hotel.Add(hotel);
            return hotel;
        }

        public async Task<Hotel> GetHotel(int Id)
        {
            return _database.Hotel.Where(x => x.Id == Id).FirstOrDefault();
        }

        public async Task<IEnumerable<Hotel>> GetHotels()
        {
            return _database.Hotel;
        }
    }
}
