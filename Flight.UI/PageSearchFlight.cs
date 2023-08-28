using System;
using System.Collections;
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
    public enum FlightEnum
    {
        From,
        To,
        Price
    }
    public partial class PageSearchFlight : UserControl, State
    {
        FlightRepository flightRepository = new FlightRepository();
        private IEnumerable<FlightInstance> flights;

        public PageSearchFlight()
        {
            InitializeComponent();
            comboBox_type.Items.AddRange(Enum.GetNames(typeof(FlightEnum)).ToArray());
            dataGridView_searchflights.AutoGenerateColumns = true;
        }

        private void PageSearchFlight_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Globals.PATH_FLIGHT_REPO))
            {
                FormHost.MessageBoxGenerator("No flights found!", "Warning");
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if(textBox_value.Text.Length == 0 ||
               comboBox_type.Text.Length == 0)
            {
                FormHost.MessageBoxGenerator("Please fill in all of the fields", "Warning");
                return;
            }
            
            if (File.Exists(Globals.PATH_FLIGHT_REPO))
            {
                flightRepository.LoadFromJson(Globals.PATH_FLIGHT_REPO);
            }

            var value = textBox_value.Text;

            switch (comboBox_type.SelectedIndex)
            {
                case 0:
                    flights = flightRepository.GetAll().Where(elem => elem.From.StartsWith(value));
                    break;

                case 1:
                    flights = flightRepository.GetAll().Where(elem => elem.To.StartsWith(value));
                    break;

                case 2:
                    flights = flightRepository.GetAll().Where(elem => elem.Price.Equals(Convert.ToDouble(value)));
                    break;
            }

            dataGridView_searchflights.DataSource = flights.ToList();
            dataGridView_searchflights.Update();
            dataGridView_searchflights.Refresh();
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
