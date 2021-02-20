using FlightBooking.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FlightBooking.Service.Interface
{
    public interface IHotelService
    {
        Task<Hotel> AddHotel(Hotel hotel);
        Task<IEnumerable<Hotel>> GetHotels();
        Task<Hotel> GetHotel(int Id);
    }
}
