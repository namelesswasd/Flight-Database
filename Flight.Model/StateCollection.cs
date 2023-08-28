using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flight.Model
{
    public enum FormLocation
    {
        Login,              //   initial
        Register,           //any
        AddFlight,          //    admin
        ModifyFlight,       //    admin
        RemoveFlight,       //    admin
        ReserveFlight,      //any
        BuyFlight,          //any
        SearchFlight,       //any
        ListFlights,        //any
        Help,
        Exit
    }

    public class StateCollection : Dictionary<int, State>
    {
        public State? CurrentPage { get; private set; }
        public FormLocation PageLocation { get; private set; }

        public StateCollection()
        {
            PageLocation = FormLocation.Login;
        }

        public State? MoveToPage(int page_index)
        {
            try
            {
                CurrentPage = this[page_index];
                return CurrentPage;
            }
            catch(KeyNotFoundException) { }
            {
                return null;
            }
        }
    }
}
