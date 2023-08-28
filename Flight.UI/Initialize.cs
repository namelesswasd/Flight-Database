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
    public partial class Initialize : Form
    {
        public FormHost host = new FormHost();

        public Initialize()
        {
            InitializeComponent();
            host.States.Add(0, new PageLogin());
            host.States.Add(1, new PageRegister());
            host.States.Add(2, new PageAddFlight());
            host.States.Add(3, new PageModifyFlight());
            host.States.Add(4, new PageRemoveFlight());
            host.States.Add(5, new PageReserveFlight());
            host.States.Add(6, new PageBuyFlight());
            host.States.Add(7, new PageSearchFlight());
            host.States.Add(8, new PageListFlights());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            host.Text = "Flight Wizard App";

            host.Setup();
            host.LoadPageIndex(0);
            host.ShowDialog();
        }
    }
}
