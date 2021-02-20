using System;
using System.Collections.Generic;
using System.Text;

namespace FlightBooking.Model
{
    public class Flight
    {
        public int Id { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }
        public int TotalSeats { get; set; }

        // In realtime we'll query the count of booked seats from another entity/table
        public int BookedSeats { get; set; }
    }
}
