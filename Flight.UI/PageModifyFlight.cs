using Flight.DataAccess;
using Flight.DataAccess.Repositories;
using Flight.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flight.UI
{
    public partial class PageModifyFlight : UserControl, State
    {
        FlightRepository flightRepository = new FlightRepository();
        private IEnumerable<FlightInstance> flights;

        public PageModifyFlight()
        {
            InitializeComponent();
        }

        private void PageModifyFlight_Load(object sender, EventArgs e)
        {
            if(File.Exists(Globals.PATH_FLIGHT_REPO))
            {
                flightRepository.LoadFromJson(Globals.PATH_FLIGHT_REPO);
            } else { FormHost.MessageBoxGenerator("No flights found, create one!", "Warning"); }
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

        private void button_modifyFlight_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text.Length == 0 ||
               textBox_from.Text.Length == 0 ||
               textBox_to.Text.Length == 0 ||
               textBox_price.Text.Length == 0)
            {
                FormHost.MessageBoxGenerator("Please fill in all of the fields", "Warning");
                return;
            }

            flights = flightRepository.GetAll();

            foreach(FlightInstance f in flights)
            {
                if(f.FlightID == Convert.ToInt16(textBox_ID.Text))
                {
                    flightRepository.Update(f.FlightID, new FlightInstance(
                        Convert.ToInt16(textBox_ID.Text),
                        textBox_from.Text,
                        textBox_to.Text,
                        dateTimePicker.Value.Date,
                        Convert.ToDouble(textBox_price.Text)
                    ));
                }
                FormHost.MessageBoxGenerator("Flight modified!", "Information");

                flightRepository.SaveToJson(Globals.PATH_FLIGHT_REPO);

                return;
            }
            FormHost.MessageBoxGenerator("Flight not found!", "Information");
        }
    }
}
