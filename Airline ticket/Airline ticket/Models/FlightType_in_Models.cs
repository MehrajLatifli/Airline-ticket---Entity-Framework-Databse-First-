using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket.Models
{
    public class FlightType_in_Models : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnpropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(name));
            }
        }

        public FlightType_in_Models() { }


        public string _Flight_Type;

        public string Flight_Type
        {
            get { return _Flight_Type; }
            set { _Flight_Type = value; OnpropertyChanged(); }
        }
    }
}
