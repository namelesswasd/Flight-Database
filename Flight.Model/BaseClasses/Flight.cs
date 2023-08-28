using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.DataAccess
{
    public class FlightInstance
    {
        public int FlightID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; }
        public double Price { get; set; }

        public FlightInstance() { }
        public FlightInstance(int flight_id, string from, string to, DateTime date, double price) {
            this.FlightID = flight_id;
            this.From = from;
            this.To = to;
            this.Date = date;
            this.Price = price;
        }

        public override string ToString()
        {
            return "FlightID: " + this.FlightID +
                   "\nFrom: " + this.From +
                   "\nTo: " + this.To +
                   "\nDateTime: " + this.Date.ToString() +
                   "\nPrice: " + this.Price;
        }
    }
}
