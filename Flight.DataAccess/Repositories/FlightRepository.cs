using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Flight.Model;

namespace Flight.DataAccess.Repositories
{
    public class FlightRepository : IRepository<FlightInstance>
    {
        private List<FlightInstance> _flights;

        public FlightRepository()
        {
            _flights = new List<FlightInstance>();  
        }

        public IEnumerable<FlightInstance> GetAll()
        {
            return _flights;
        }

        public FlightInstance Get(int id)
        {
            return _flights.FirstOrDefault(f => f.FlightID == id);
        }

        public void SaveToJson(string filePath)
        {
            string json = JsonSerializer.Serialize(_flights);
            File.WriteAllText(filePath, json);
        }

        public void LoadFromJson(string filePath)
        {
            string json = File.ReadAllText(filePath);
            _flights = JsonSerializer.Deserialize<List<FlightInstance>>(json);
        }

        public FlightInstance GetLast()
        {
            return _flights.Last();
        }

        public string GetToString(int id)
        {
            var t = _flights.FirstOrDefault(f => f.FlightID == id);
            return "FlightInstance(" +
                t.FlightID.ToString() + ", " +
                t.From.ToString() + ", " +
                t.To.ToString() + ", " +
                t.Date.ToString() + ", " +
                t.Price.ToString() + ")";
        }

        public void Create(FlightInstance flight)
        {
            _flights.Add(flight);
        }

        public void Update(int id, FlightInstance flight)
        {
            var oldFlight = _flights.FirstOrDefault(f => f.FlightID == id);
            if (oldFlight != null)
            {
                oldFlight.From = flight.From;
                oldFlight.To = flight.To;
                oldFlight.Date = flight.Date;
                oldFlight.Price = flight.Price;
            }
        }

        public void Delete(int id)
        {
            var removeFlight = _flights.FirstOrDefault(f => f.FlightID == id);
            if(removeFlight != null)
            {
                _flights.Remove(removeFlight);
            }
        }
    }
}
