using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flight.DataAccess.BaseClasses;
using Flight.DataAccess.Repositories;
using Flight.DataAccess;
using Flight.Model;

namespace Flight.UI
{
    public partial class PageBuyFlight : UserControl, State
    {
        User logged_user = new User();

        FlightRepository flightRepository = new FlightRepository();
        private IEnumerable<FlightInstance> flights;

        FlightResRepository reservationRepository = new FlightResRepository();
        private IEnumerable<FlightReservation> reservations;

        public PageBuyFlight()
        {
            InitializeComponent();
        }

        private void PageBuyFlight_Load(object sender, EventArgs e)
        {
            if (File.Exists(Globals.PATH_LOGGED_USER))
            {
                logged_user = logged_user.LoadUserFromDisk(Globals.PATH_LOGGED_USER);
            }
            if (File.Exists(Globals.PATH_FLIGHT_REPO))
            {
                flightRepository.LoadFromJson(Globals.PATH_FLIGHT_REPO);
                flights = flightRepository.GetAll();
            }
            if (File.Exists(Globals.PATH_RESERVE_REPO))
            {
                reservationRepository.LoadFromJson(Globals.PATH_RESERVE_REPO);
                reservations = reservationRepository.GetAll();
            }
        }

        private void button_purchase_Click(object sender, EventArgs e)
        {
            if (textBox_flightID.Text.Length == 0)
            {
                FormHost.MessageBoxGenerator("Please fill in all of the fields", "Warning");
                return;
            }

            if (flights != null)
            {
                foreach (var flight in flights)
                {
                    if (flight.FlightID == Convert.ToInt16(textBox_flightID.Text))
                    {
                        FormHost.MessageBoxGenerator("The flight from " + flight.From + " to " + flight.To + " for " + flight.Price + Environment.NewLine + "has been purchased!", "Information");
                        return;
                    }
                }
            }
            else
            {
                FormHost.MessageBoxGenerator("No flights were reserved!", "Warning");
                return;
            }


            FormHost.MessageBoxGenerator("Flight has not been found", "Warning");
            return;
        }

        private void PageBuyFlight_VisibleChanged(object sender, EventArgs e)
        {
            if (File.Exists(Globals.PATH_FLIGHT_REPO) && File.Exists(Globals.PATH_RESERVE_REPO))
            {
                flights = flights.Where(f_elem => reservations.Any(r_elem => r_elem.FlightID == f_elem.FlightID && r_elem.UserID == logged_user.ID));
            }
            else
            {
                FormHost.MessageBoxGenerator("No reservations were added.", "Warning");
                return;
            }

            dataGridView1.DataSource = flights.ToList();
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
