using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Airline_ticket.Models
{
    public class Pilot_in_Models : INotifyPropertyChanged
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

        public Pilot_in_Models() { }


        public string _Pilots_name;

        public string Pilots_name
        {
            get { return _Pilots_name; }
            set { _Pilots_name = value; OnpropertyChanged(); }
        }

        public string _Pilots_surname;

        public string Pilots_surname
        {
            get { return _Pilots_surname; }
            set { _Pilots_surname = value; OnpropertyChanged(); }
        }

        public string FullPilot => $"{Pilots_name.ToString()}    {Pilots_surname.ToString()}";
    }
}
