using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flight.DataAccess;
using Flight.DataAccess.BaseClasses;
using Flight.DataAccess.Repositories;
using Flight.Model;

namespace Flight.UI
{

    public partial class PageReserveFlight : UserControl, State
    {
        User logged_user = new User();

        FlightRepository flightRepository = new FlightRepository();
        private IEnumerable<FlightInstance> flights;

        FlightResRepository reservationRepository = new FlightResRepository();
        private IEnumerable<FlightReservation> reservations;

        public PageReserveFlight()
        {
            InitializeComponent();
        }

        private void PageReserveFlight_Load(object sender, EventArgs e)
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

        private void button_reserve_Click(object sender, EventArgs e)
        {
            var date = dateTimePicker.Value;


            if (textBox_flightID.Text.Length == 0)
            {
                FormHost.MessageBoxGenerator("Please fill in all of the fields", "Warning");
                return;
            }

            if (File.Exists(Globals.PATH_FLIGHT_REPO))
            {
                reservationRepository.Create(new FlightReservation(
                logged_user,
                flightRepository.Get(Convert.ToInt16(textBox_flightID.Text)),
                date,
                date.AddDays(7)
                ));
            } else
            {
                FormHost.MessageBoxGenerator("No flights in the database." + Environment.NewLine + "Please contact an admin to add flights.", "Warning");
                return;
            }
                

            FormHost.MessageBoxGenerator("Reservation created!" + Environment.NewLine + "Your reservation will expire on " + date.AddDays(7).Date, "Information");

            reservationRepository.SaveToJson(Globals.PATH_RESERVE_REPO);
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
