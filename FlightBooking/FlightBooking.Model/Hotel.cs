namespace FlightBooking.Model
{
    public class Hotel
    {
        public int Id { get; set; }
        public string City { get; set; }
        public int TotalRooms { get; set; }

        // In realtime we'll query the count of booked rooms from another entity/table
        public int BookedRooms { get; set; }


    }
}
