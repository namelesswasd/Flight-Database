using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.DataAccess.BaseClasses
{
    public class FlightReservation
    {
        public int UserID { get; set; }
        public int FlightID { get; set; }
        public DateTime Date { get; set; }
        public DateTime ExpirationDate { get; set; }

        public FlightReservation() { }
        
        public FlightReservation(User user_id, FlightInstance flight_id, DateTime date, DateTime exp_date)
        {
            UserID = user_id.ID;
            FlightID = flight_id.FlightID;
            Date = date;
            ExpirationDate = exp_date;
        }
    }
}
