using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flight.DataAccess.Repositories;
using Flight.DataAccess;
using Flight.Model;

namespace Flight.UI
{
    public partial class PageListFlights : UserControl, State
    {
        FlightRepository flightRepository = new FlightRepository();
        private IEnumerable<FlightInstance> flights;

        public PageListFlights()
        {
            InitializeComponent();
        }

        private void PageListFlights_Load(object sender, EventArgs e)
        {
            if (File.Exists(Globals.PATH_FLIGHT_REPO))
            {
                flightRepository.LoadFromJson(Globals.PATH_FLIGHT_REPO);
                flights = flightRepository.GetAll();

                dataGridView_flights.DataSource = flights;
            }
            else { FormHost.MessageBoxGenerator("No flights found!", "Warning"); }
        }

        public UserControl Content
        {
            get { return this; }
        }

        public bool PageValid
        {
            get { return true; }
        }

        public string ValidationMessage
        {
            get { return ""; }
        }
    }
}
