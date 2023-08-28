using Flight.DataAccess.Repositories;
using Flight.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Flight.Model;

namespace Flight.UI
{
    public partial class PageRemoveFlight : UserControl, State
    {
        FlightRepository flightRepository = new FlightRepository();
        private IEnumerable<FlightInstance> flights;

        public PageRemoveFlight()
        {
            InitializeComponent();
        }

        private void PageRemoveFlight_Load(object sender, EventArgs e)
        {
            if (File.Exists(Globals.PATH_FLIGHT_REPO))
            {
                flightRepository.LoadFromJson(Globals.PATH_FLIGHT_REPO);
            }
            else { FormHost.MessageBoxGenerator("No flights found, create one!", "Warning"); }
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

        private void button_removeFlight_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text.Length == 0)
            {
                FormHost.MessageBoxGenerator("Please fill in all of the fields", "Warning");
                return;
            }

            flights = flightRepository.GetAll();

            foreach (FlightInstance f in flights)
            {
                if (f.FlightID == Convert.ToInt16(textBox_ID.Text))
                {
                    flightRepository.Delete(f.FlightID);

                    FormHost.MessageBoxGenerator("Flight deleted!", "Information");
                    flightRepository.SaveToJson(Globals.PATH_FLIGHT_REPO);
                    return;
                }
            }
            FormHost.MessageBoxGenerator("Flight not found!", "Warning");
        }

        private void button_fetchFlight_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text.Length == 0)
            {
                FormHost.MessageBoxGenerator("Please fill in all of the fields", "Warning");
                return;
            }

            var found = false;

            flights = flightRepository.GetAll();

            foreach (FlightInstance f in flights)
            {
                if (f.FlightID == Convert.ToInt16(textBox_ID.Text))
                {
                    label_fetchFlight.Text = f.ToString();
                    found = true;
                }
            }

            if (!found)
            {
                label_fetchFlight.Text = "Flight not found!";
            }
        }
    }
}
