using Flight.DataAccess.BaseClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Flight.DataAccess.Repositories
{
    public class FlightResRepository : IRepository<FlightReservation>
    {
        private List<FlightReservation> _reservations;

        public FlightResRepository()
        {
            _reservations = new List<FlightReservation>();
        }

        public IEnumerable<FlightReservation> GetAll()
        {
            return _reservations;
        }

        public FlightReservation Get(int id)
        {
            return _reservations.FirstOrDefault(r => r.FlightID == id);
        }

        public void SaveToJson(string filePath)
        {
            string json = JsonSerializer.Serialize(_reservations);
            File.WriteAllText(filePath, json);
        }

        public void LoadFromJson(string filePath)
        {
            string json = File.ReadAllText(filePath);
            _reservations = JsonSerializer.Deserialize<List<FlightReservation>>(json);
        }

        public FlightReservation GetLast()
        {
            return _reservations.Last();
        }

        public string GetToString(int id)
        {
            var t = _reservations.FirstOrDefault(r => r.FlightID == id);
            return "FlightInstance(" + ", " +
                t.UserID.ToString() + ", " +
                t.FlightID.ToString() + ", " +
                t.Date.ToString() + ", " +
                t.ExpirationDate.ToString() + ")";
        }

        public void Create(FlightReservation res)
        {
            _reservations.Add(res);
        }

        public void Update(int id, FlightReservation res)
        {
            var oldRes = _reservations.FirstOrDefault(r => r.FlightID == id);
            if (oldRes != null)
            {
                oldRes.UserID = res.UserID;
                oldRes.Date = res.Date;
                oldRes.ExpirationDate = res.ExpirationDate;
            }
        }

        public void Delete(int id)
        {
            var removeRes = _reservations.FirstOrDefault(r => r.FlightID == id);
            if (removeRes != null)
            {
                _reservations.Remove(removeRes);
            }
        }
    }
}
