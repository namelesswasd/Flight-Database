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
    public partial class PageAddFlight : UserControl, State
    {
        FlightRepository flightRepository = new FlightRepository();

        public PageAddFlight()
        {
            InitializeComponent();

            if (File.Exists(Globals.PATH_FLIGHT_REPO))
            {
                flightRepository.LoadFromJson(Globals.PATH_FLIGHT_REPO);
            }
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

        private void button_addFlight_Click(object sender, EventArgs e)
        {
            if (textBox_ID.Text.Length == 0 ||
               textBox_from.Text.Length == 0 ||
               textBox_to.Text.Length == 0 ||
               textBox_price.Text.Length == 0)
            {
                FormHost.MessageBoxGenerator("Please fill in all of the fields", "Warning");
                return;
            }

            flightRepository.Create(new DataAccess.FlightInstance(
                Convert.ToInt16(textBox_ID.Text),
                textBox_from.Text,
                textBox_to.Text,
                dateTimePicker.Value.Date,
                Convert.ToDouble(textBox_price.Text)
            ));

            FormHost.MessageBoxGenerator("Flight added!", "Information");

            flightRepository.SaveToJson(Globals.PATH_FLIGHT_REPO);
        }
    }
}
